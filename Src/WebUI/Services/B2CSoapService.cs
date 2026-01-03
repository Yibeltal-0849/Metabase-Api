
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using XOKA.Domain.Entities.Purchase;
using static IdentityModel.OidcConstants;

namespace WebUI.Services
{
   

    public class B2CSoapService
    {
        public string logDirectory = "F:\\log";
        public string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public string path;
        // private Item_Activity ia;
        private IConfiguration Configuration;


        // private readonly teleDbContext _dbContext; // Inject your DbContext here

        public B2CSoapService(IConfiguration _configuration)
        {
            // _dbContext = dbContext;
            Configuration = _configuration;
            path = Path.Combine(logDirectory, $"log_{currentDate}.txt");
        }



        public async Task<string> SendSoapRequest(string soapXml)
        {

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(soapXml);
                writer.Close();
            }
            // Parse the SOAP XML to extract the parameter values
            var parameters = ParseSoapXml(soapXml);

            // Execute the stored procedure and retrieve data using Entity Framework
            //var results = await _dbContext.YourEntities
            //    .FromSqlRaw("EXEC [FINA].[C2BPaymentQueryRequest] @TransType, @TransID, @TransTime, @BusinessShortCode, @BillRefNumber, @MSISDN",
            //                parameters)
            //    .ToListAsync();
            // Execute the stored procedure and retrieve data using SqlCommand
            var results = await ExecuteStoredProcedure(parameters);
            // Construct the SOAP response XML using the retrieved data



            var soapResponseXml = ConstructSoapResponse(results);
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(soapResponseXml);
                writer.Close();
            }
            return soapResponseXml;
        }
        private async Task<B2CPaymentQueryRequestmap> ExecuteStoredProcedure(Dictionary<string, string> parameters)
        {
            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("[dbo].[B2CPaymentQueryRequest]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the SqlCommand
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        using (StreamWriter writer = new StreamWriter(path, true))
                        {
                            writer.WriteLine($"Key: {parameter.Key}, Value: {parameter.Value}");
                        }
                    }

                    // Add output parameters
                    command.Parameters.Add(new SqlParameter("@ResponseCode", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResponseDesc", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@OriginatorConversationID", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ConversationID", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ServiceStatus", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
           
                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    var ResponseCode = (int)command.Parameters["@ResponseCode"].Value;
                    var ResponseDesc = (string)command.Parameters["@ResponseDesc"].Value;
                    var OriginatorConversationID = (string)command.Parameters["@OriginatorConversationID"].Value;
                    var ConversationID = (string)command.Parameters["@ConversationID"].Value;
                    var ServiceStatus = (string)command.Parameters["@ServiceStatus"].Value;

                    // Create a C2BPaymentQueryRequestmap instance to hold the output values
                    var result = new B2CPaymentQueryRequestmap
                    {
                        
                      ResponseCode = ResponseCode,
        ResponseDesc =ResponseDesc,
        OriginatorConversationID =OriginatorConversationID,
        ConversationID = ConversationID,
        ServiceStatus =ServiceStatus
    };

                    return result;
                }
            }
        }



        private Dictionary<string, string> ParseSoapXml(string soapXml)
        {
            var parameters = new Dictionary<string, string>();
            string logFilePath = "F:\\log\\parsing_log.txt"; // Define the path for the log file

            try
            {
                // Load the SOAP XML into an XmlDocument for easier traversal
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(soapXml);

                // Create a namespace manager to handle namespaces
                XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
                namespaceManager.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                namespaceManager.AddNamespace("req", "http://cps.huawei.com/cpsinterface/request");

                // Extract the CDATA content from RequestMsg
                XmlNode requestMsgNode = xmlDoc.SelectSingleNode("//soapenv:Body/req:RequestMsg", namespaceManager);
                if (requestMsgNode != null)
                {
                    // Load the CDATA content into a new XmlDocument for easier traversal
                    string cdataContent = requestMsgNode.InnerText.Trim();
                    XmlDocument requestDoc = new XmlDocument();
                    requestDoc.LoadXml(cdataContent);

                    // Extract specific known fields
                    parameters["KeyOwner"] = requestDoc.SelectSingleNode("//Request/KeyOwner")?.InnerText;
                    parameters["CallerType"] = requestDoc.SelectSingleNode("//Caller/CallerType")?.InnerText;
                    parameters["ThirdPartyID"] = requestDoc.SelectSingleNode("//Caller/ThirdPartyID")?.InnerText;
                    parameters["Password"] = requestDoc.SelectSingleNode("//Caller/Password")?.InnerText;
                    parameters["ResultURL"] = requestDoc.SelectSingleNode("//Caller/ResultURL")?.InnerText;
                    parameters["IdentifierType"] = requestDoc.SelectSingleNode("//Initiator/IdentifierType")?.InnerText;
                    parameters["Identifier"] = requestDoc.SelectSingleNode("//Initiator/Identifier")?.InnerText;
                    parameters["SecurityCredential"] = requestDoc.SelectSingleNode("//Initiator/SecurityCredential")?.InnerText;
                    parameters["ShortCode"] = requestDoc.SelectSingleNode("//Initiator/ShortCode")?.InnerText;
                    parameters["ReceiverIdentifierType"] = requestDoc.SelectSingleNode("//ReceiverParty/IdentifierType")?.InnerText;
                    parameters["ReceiverIdentifier"] = requestDoc.SelectSingleNode("//ReceiverParty/Identifier")?.InnerText;
                    parameters["CommandID"] = requestDoc.SelectSingleNode("//Transaction/CommandID")?.InnerText;
                    parameters["Timestamp"] = requestDoc.SelectSingleNode("//Transaction/Timestamp")?.InnerText;

                    // Recursively extract all parameter nodes in the nested XML
                    ExtractParameters(requestDoc.DocumentElement, parameters);
                }

                // Log the parsing results
                LogParsingResults(parameters, logFilePath);
            }
            catch (Exception ex)
            {
                // Handle any parsing exceptions and log the error
                File.AppendAllText(logFilePath, $"SOAP XML parsing error: {ex.Message}\n");
                Console.WriteLine("SOAP XML parsing error: " + ex.Message);
            }

            return parameters;
        }

        private void ExtractParameters(XmlNode node, Dictionary<string, string> parameters)
        {
            // Iterate over child nodes to extract keys and values
            foreach (XmlNode child in node.ChildNodes)
            {
                // Extract nodes with specific structures (Parameters, ReferenceData, etc.)
                if (child.Name == "Parameter" || child.Name == "ReferenceItem")
                {
                    var keyNode = child.SelectSingleNode("Key");
                    var valueNode = child.SelectSingleNode("Value");
                    if (keyNode != null && valueNode != null)
                    {
                        parameters[keyNode.InnerText] = valueNode.InnerText;
                    }
                }
                else if (child.HasChildNodes)
                {
                    // Recursively call for nested nodes
                    ExtractParameters(child, parameters);
                }
            }
        }

        private void LogParsingResults(Dictionary<string, string> parameters, string logFilePath)
        {
            //using (StreamWriter writer = new StreamWriter(logFilePath, true))
            //{
            //    writer.WriteLine("Parsed Parameters:");
            //    foreach (var parameter in parameters)
            //    {
            //        writer.WriteLine($"Key: {parameter.Key}, Value: {parameter.Value}");
            //    }
            //    writer.WriteLine("----------------------------------------------------");
            //}
        }

        private string ConstructSoapResponse(B2CPaymentQueryRequestmap result)
        {
            // Define the SOAP envelope and namespaces
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace req = "http://cps.huawei.com/cpsinterface/request";

            // Create the SOAP envelope with the appropriate namespaces
            XElement soapEnvelope = new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
                new XAttribute(XNamespace.Xmlns + "req", req),
                new XElement(soapenv + "Header"),
                new XElement(soapenv + "Body",
                    new XElement(req + "ResponseMsg",
                        new XCData($@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Response>
  <ResponseCode>{result.ResponseCode}</ResponseCode>
  <ResponseDesc>{result.ResponseDesc}</ResponseDesc>
  <OriginatorConversationID>{result.OriginatorConversationID}</OriginatorConversationID>
  <ConversationID>{result.ConversationID}</ConversationID>
  <ServiceStatus>{result.ServiceStatus}</ServiceStatus>
</Response>")
                    )
                )
            );

            // Convert the SOAP envelope to a string
            string soapResponseXml = soapEnvelope.ToString();

            return soapResponseXml;
        }


    }


}
