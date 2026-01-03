
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

namespace WebUI.Services
{


    public class B2CResponseSoapService
    {
        public string logDirectory = "F:\\log";
        public string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public string path;
        // private Item_Activity ia;
        private IConfiguration Configuration;


        // private readonly teleDbContext _dbContext; // Inject your DbContext here

        public B2CResponseSoapService(IConfiguration _configuration)
        {
            // _dbContext = dbContext;
            Configuration = _configuration;
            path = Path.Combine(logDirectory, $"log_{currentDate}.txt");
        }



        public async Task<string> SendSoapRequest(string soapXml)
        {

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("-------------");
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
        private async Task<B2CPaymentQueryResponsemap> ExecuteStoredProcedure(Dictionary<string, string> parameters)
        {
            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("[dbo].[B2CPaymentQueryResponse]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the SqlCommand
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    // Add output parameters
                    command.Parameters.Add(new SqlParameter("@ResultType", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResultCode", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResultDesc", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@OriginatorConversationIDs", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ConversationIDs", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@TranactionID", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResultParameters", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    var ResultType = (int)command.Parameters["@ResultType"].Value;
                    var ResultCode = (int)command.Parameters["@ResultCode"].Value;
                    var ResultDesc = (string)command.Parameters["@ResultDesc"].Value;
                    var OriginatorConversationIDs = (string)command.Parameters["@OriginatorConversationIDs"].Value;
                    var ConversationIDs = (string)command.Parameters["@ConversationIDs"].Value;
                    var ResultParameters = (string)command.Parameters["@ResultParameters"].Value;
                    var TranactionID = (string)command.Parameters["@TranactionID"].Value;

                    // Create a B2CPaymentQueryResponsemap instance to hold the output values
                    var result = new B2CPaymentQueryResponsemap
                    {
                        ResultType = ResultType,
                        ResultCode = ResultCode,
                        ResultDesc = ResultDesc,
                        OriginatorConversationIDs = OriginatorConversationIDs,
                        ConversationIDs = ConversationIDs,
                        ResultParameters = ResultParameters,
                        TranactionID = TranactionID
                    };

                    return result;
                }
            }
        }



        private Dictionary<string, string> ParseSoapXml(string soapXml)
        {
            var parameters = new Dictionary<string, string>();
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("Formatted XML");
                writer.WriteLine(soapXml);
                writer.WriteLine("----------------------------------------------------");
            }

            try
            {
                // Load the SOAP XML into an XmlDocument for easier traversal
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(soapXml);

                // Create a namespace manager to handle namespaces
                XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
                namespaceManager.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                namespaceManager.AddNamespace("req", "http://cps.huawei.com/cpsinterface/request");

                // Extract the CDATA content inside <req:ResponseMsg>
                var cdataContent = xmlDoc.SelectSingleNode("//req:ResponseMsg", namespaceManager)?.InnerText;
                if (!string.IsNullOrEmpty(cdataContent))
                {
                    // Load the CDATA content as a new XML document
                    XmlDocument cdataDoc = new XmlDocument();
                    cdataDoc.LoadXml(cdataContent);

                    // Extract values using XPath expressions from the CDATA XML
                    parameters["@ResponseCode"] = cdataDoc.SelectSingleNode("//ResponseCode")?.InnerText;
                    parameters["@ResponseDesc"] = cdataDoc.SelectSingleNode("//ResponseDesc")?.InnerText;
                    parameters["@OriginatorConversationID"] = cdataDoc.SelectSingleNode("//OriginatorConversationID")?.InnerText;
                    parameters["@ConversationID"] = cdataDoc.SelectSingleNode("//ConversationID")?.InnerText;
                    parameters["@ServiceStatus"] = cdataDoc.SelectSingleNode("//ServiceStatus")?.InnerText;
                }

                LogParsingResults(parameters, path);
            }
            catch (Exception ex)
            {
                // Handle any parsing exceptions
                Console.WriteLine("SOAP XML parsing error: " + ex.Message);
            }

            return parameters;
        }

        private void LogParsingResults(Dictionary<string, string> parameters, string logFilePath)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine("Parsed Parameters:");
                foreach (var parameter in parameters)
                {
                    writer.WriteLine($"Key: {parameter.Key}, Value: {parameter.Value}");
                }
                writer.WriteLine("----------------------------------------------------");
            }
        }
        //private string ConstructSoapResponse(B2CPaymentQueryResponsemap result)
        //{
        //    // Define the SOAP envelope and namespaces
        //    XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
        //    XNamespace req = "http://cps.huawei.com/cpsinterface/result";

        //    // Create the SOAP envelope with the appropriate namespaces
        //    XElement soapEnvelope = new XElement(soapenv + "Envelope",
        //        new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
        //        new XElement(soapenv + "Header"),
        //        new XElement(soapenv + "Body",
        //            new XElement(req + "ResultMsg",
        //                new XAttribute(XNamespace.Xmlns + "req", req),
        //                new XElement("Result",
        //                    new XElement("ResultType", result.ResultType),
        //                    new XElement("ResultCode", result.ResultCode),
        //                    new XElement("ResultDesc", result.ResultDesc),
        //                    new XElement("OriginatorConversationID", result.OriginatorConversationIDs),
        //                    new XElement("ConversationID", result.ConversationIDs),
        //                    new XElement("TranactionID", result.TranactionID),
        //                    new XElement("ResultParameters", result.ResultParameters)
        //                )
        //            )
        //        )
        //    );

        //    // Convert the SOAP envelope to a string with proper formatting
        //    string soapResponseXml = {Environment.NewLine}$@"<?xml version=""1.0"" encoding=""UTF-8""?>{soapEnvelope}";

        //    return soapResponseXml;
        //}
        private string ConstructSoapResponse(B2CPaymentQueryResponsemap result)
        {
            // Define the SOAP envelope and namespaces
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace req = "http://cps.huawei.com/cpsinterface/result";

            // Create the SOAP envelope with the appropriate namespaces
            XElement soapEnvelope = new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
                new XElement(soapenv + "Header"), // Empty header
                new XElement(soapenv + "Body",
                    new XElement(req + "ResultMsg", // Using the 'req' namespace
                        new XAttribute(XNamespace.Xmlns + "req", req), // Add the 'req' namespace to this element
                        new XCData($@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Result>
    <ResultType>{result.ResultType}</ResultType>
    <ResultCode>{result.ResultCode}</ResultCode>
    <ResultDesc>{result.ResultDesc}</ResultDesc>
    <OriginatorConversationID>{result.OriginatorConversationIDs}</OriginatorConversationID>
    <ConversationID>{result.ConversationIDs}</ConversationID>
    <TranactionID>{result.TranactionID}</TranactionID>
    <ResultParameters>{result.ResultParameters}</ResultParameters>
</Result>")
                    )
                )
            );

            // Convert the SOAP envelope to a string
            string soapResponseXml = soapEnvelope.ToString(SaveOptions.DisableFormatting);

            return soapResponseXml;
        }


    }


}
