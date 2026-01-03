
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
using XOKA.Domain.Entities.Finance;

namespace WebUI.Services
{
  

    public class SoapServiceTelbirr
    {
        public string logDirectory = "F:\\log";
        public string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public string path;

        // private Item_Activity ia;
        private IConfiguration Configuration;

     
       // private readonly teleDbContext _dbContext; // Inject your DbContext here

        public SoapServiceTelbirr( IConfiguration _configuration)
        {
            // _dbContext = dbContext;
            path = Path.Combine(logDirectory, $"log_{currentDate}.txt");

            Configuration = _configuration;
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
        private async Task<C2BPaymentQueryRequestmap> ExecuteStoredProcedure(Dictionary<string, string> parameters)
        {
            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("[FINA].[C2BPaymentQueryRequest]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the SqlCommand
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    // Add output parameters
                    command.Parameters.Add(new SqlParameter("@ResultCode", SqlDbType.NVarChar, 4000) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResultDesc", SqlDbType.NVarChar, 4000) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@TransIDOutput", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@BillRefNumberOutput", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@UtilityName", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Float) { Direction = ParameterDirection.Output });

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    var resultCode = (string)command.Parameters["@ResultCode"].Value;
                    var resultDesc = (string)command.Parameters["@ResultDesc"].Value;
                    var transIDOutput = (string)command.Parameters["@TransIDOutput"].Value;
                    var billRefNumberOutput = (string)command.Parameters["@BillRefNumberOutput"].Value;
                    var utilityName = (string)command.Parameters["@UtilityName"].Value;
                    var customerName = (string)command.Parameters["@CustomerName"].Value;
                    var amount = (double)command.Parameters["@Amount"].Value;

                    // Create a C2BPaymentQueryRequestmap instance to hold the output values
                    var result = new C2BPaymentQueryRequestmap
                    {
                        ResultCode = resultCode,
                        ResultDesc = resultDesc,
                        TransID = transIDOutput,
                        BillRefNumber = billRefNumberOutput,
                        UtilityName = utilityName,
                        CustomerName = customerName,
                        Amount = amount
                    };

                    return result;
                }
            }
        }


        //private async Task<List<C2BPaymentQueryRequest>> ExecuteStoredProcedure(Dictionary<string, string> parameters)
        //{
        //    // Create a connection to your database using the connection string
        //    using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
        //    {
        //        await connection.OpenAsync();

        //        // Create a SqlCommand instance for your stored procedure
        //        using (var command = new SqlCommand("[FINA].[C2BPaymentQueryRequest]", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            // Add parameters to the SqlCommand
        //            foreach (var parameter in parameters)
        //            {
        //                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
        //            }
        //            //command.Parameters.AddWithValue("@Inv_ID", commmand.Inv_ID);

        //            // Execute the stored procedure and retrieve data
        //            using (var reader = await command.ExecuteReaderAsync())
        //            {
        //                var results = new List<C2BPaymentQueryRequest>();

        //                while (await reader.ReadAsync())
        //                {
        //                    // Create instances of YourStoredProcResult and populate with data from reader
        //                    var result = new C2BPaymentQueryRequest
        //                    {
        //                        // Map reader columns to YourStoredProcResult properties
        //                        ResultCode = reader.GetString(reader.GetOrdinal("resultCode")),
        //                        ResultDesc = reader.GetString(reader.GetOrdinal("resultDesc")),
        //                        TransID = reader.GetString(reader.GetOrdinal("transID")),
        //                        BillRefNumber = reader.GetString(reader.GetOrdinal("billRefNumber")),
        //                        UtilityName = reader.GetString(reader.GetOrdinal("utilityName")),
        //                        CustomerName = reader.GetString(reader.GetOrdinal("customerName")),
        //                        Amount = reader.GetDouble(reader.GetOrdinal("amount"))
        //                    };

        //                    results.Add(result);
        //                }

        //                return results;
        //            }
        //        }
        //    }
        //}
        //private Dictionary<string, object> ParseSoapXml(string soapXml)
        //{
        //    var parameters = new Dictionary<string, object>();

        //    try
        //    {
        //        XNamespace web = "http://www.example.com/webservice";

        //        // Convert the XmlDocument to a string
        //        string soapXmlString = soapXml.OuterXml;

        //        // Parse the XML string as an XDocument
        //        var doc = XDocument.Parse(soapXmlString);

        //        var transType = doc.Descendants(web + "TransType").FirstOrDefault()?.Value;
        //        var transID = doc.Descendants(web + "TransID").FirstOrDefault()?.Value;
        //        var transTime = doc.Descendants(web + "TransTime").FirstOrDefault()?.Value;
        //        var businessShortCode = doc.Descendants(web + "BusinessShortCode").FirstOrDefault()?.Value;
        //        var billRefNumber = doc.Descendants(web + "BillRefNumber").FirstOrDefault()?.Value;
        //        var msisdn = doc.Descendants(web + "MSISDN").FirstOrDefault()?.Value;

        //        parameters["@TransType"] = transType;
        //        parameters["@TransID"] = transID;
        //        parameters["@TransTime"] = transTime;
        //        parameters["@BusinessShortCode"] = businessShortCode;
        //        parameters["@BillRefNumber"] = billRefNumber;
        //        parameters["@MSISDN"] = msisdn;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any parsing exceptions
        //        // Log or handle the exception as needed
        //    }

        //    return parameters;
        //}
        private Dictionary<string, string> ParseSoapXml(string soapXml)
        {
            var parameters = new Dictionary<string, string>();

            try
            {
                // Load the SOAP XML into an XmlDocument for easier traversal
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(soapXml);

                // Create a namespace manager to handle namespaces
                XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
                namespaceManager.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                namespaceManager.AddNamespace("c2b", "http://cps.huawei.com/cpsinterface/c2bpayment");

                // Extract values using XPath expressions
                parameters["@TransType"] = xmlDoc.SelectSingleNode("//TransType", namespaceManager)?.InnerText;
                parameters["@TransID"] = xmlDoc.SelectSingleNode("//TransID", namespaceManager)?.InnerText;
                parameters["@TransTime"] = xmlDoc.SelectSingleNode("//TransTime", namespaceManager)?.InnerText;
                parameters["@BusinessShortCode"] = xmlDoc.SelectSingleNode("//BusinessShortCode", namespaceManager)?.InnerText;
                parameters["@BillRefNumber"] = xmlDoc.SelectSingleNode("//BillRefNumber", namespaceManager)?.InnerText;
                parameters["@MSISDN"] = xmlDoc.SelectSingleNode("//MSISDN", namespaceManager)?.InnerText;
            }
            catch (Exception ex)
            {
                // Handle any parsing exceptions
                // Log or handle the exception as needed
                Console.WriteLine("SOAP XML parsing error: " + ex.Message);
            }

            return parameters;
        }
        //private Dictionary<string, object> ParseSoapXml(string soapXml)
        //{
        //    var parameters = new Dictionary<string, object>();

        //    try
        //    {
        //        XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
        //        XNamespace web = "http://www.example.com/webservice";

        //        var doc = XDocument.Parse(soapXml);

        //        var transType = doc.Descendants(web + "TransType").FirstOrDefault()?.Value;
        //        var transID = doc.Descendants(web + "TransID").FirstOrDefault()?.Value;
        //        var transTime = doc.Descendants(web + "TransTime").FirstOrDefault()?.Value;
        //        var businessShortCode = doc.Descendants(web + "BusinessShortCode").FirstOrDefault()?.Value;
        //        var billRefNumber = doc.Descendants(web + "BillRefNumber").FirstOrDefault()?.Value;
        //        var msisdn = doc.Descendants(web + "MSISDN").FirstOrDefault()?.Value;

        //        parameters["@TransType"] = transType;
        //        parameters["@TransID"] = transID;
        //        parameters["@TransTime"] = transTime;
        //        parameters["@BusinessShortCode"] = businessShortCode;
        //        parameters["@BillRefNumber"] = billRefNumber;
        //        parameters["@MSISDN"] = msisdn;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any parsing exceptions
        //        // Log or handle the exception as needed
        //    }

        //    return parameters;
        //}

        //private Dictionary<string, object> ParseSoapXml(GetC2BPaymentRequest soapXml)
        //{
        //    var parameters = new Dictionary<string, object>();

        //    try
        //    {
        //        parameters["@TransType"] = soapXml.TransType;
        //        parameters["@TransID"] = soapXml.TransID;
        //        parameters["@TransTime"] = soapXml.TransTime;
        //        parameters["@BusinessShortCode"] = soapXml.BusinessShortCode;
        //        parameters["@BillRefNumber"] = soapXml.BillRefNumber;
        //        parameters["@MSISDN"] = soapXml.MSISDN;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any parsing exceptions
        //        // Log or handle the exception as needed
        //    }

        //    return parameters;
        //}



        private string ConstructSoapResponse(C2BPaymentQueryRequestmap result)
        {
            // Define the SOAP envelope and namespace
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace c2b = "http://cps.huawei.com/cpsinterface/c2bpayment";

            // Create the SOAP envelope with the appropriate namespaces
            XElement soapEnvelope = new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
                new XAttribute(XNamespace.Xmlns + "c2b", c2b),
              //  new XElement(soapenv + "Header"),
                new XElement(soapenv + "Body",
                    new XElement(c2b + "C2BPaymentQueryResult",
                   
                            new XElement( "ResultCode", result.ResultCode),
                            new XElement( "ResultDesc", result.ResultDesc),
                            new XElement( "TransID", result.TransID),
                            new XElement( "BillRefNumber", result.BillRefNumber),
                            new XElement( "UtilityName", result.UtilityName),
                            new XElement( "CustomerName", result.CustomerName),
                            new XElement( "Amount", result.Amount)
                        )
                    
                )
            );

            // Convert the SOAP envelope to a string
            string soapResponseXml = soapEnvelope.ToString();

            return soapResponseXml;
        }



    }


}
//public class teleDbContext : DbContext
//{
//    public DbSet<C2BPaymentQueryRequest> YourEntities { get; set; }

//    public teleDbContext(DbContextOptions<teleDbContext> options)
//        : base(options)
//    {
//    }
//}