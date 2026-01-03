
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
   
    public class PaymentConfirmationSoapService
    {
     
        // private Item_Activity ia;
        private IConfiguration Configuration;
        public string logDirectory = "F:\\log";
        public string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public string path;


        // private readonly teleDbContext _dbContext; // Inject your DbContext here

        public PaymentConfirmationSoapService( IConfiguration _configuration)
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
            
         
            // Execute the stored procedure and retrieve data using SqlCommand
            var results = await ExecuteStoredProcedure(parameters);
            // Construct the SOAP response XML using the retrieved data

           

            var soapResponseXml = ConstructSoapResponse(results);
            return soapResponseXml;
        }
        //private async Task<List<C2BPaymentValidationRequest>> ExecuteStoredProcedure(Dictionary<string, object> parameters)
        //{
        //    // Create a connection to your database using the connection string
        //    using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
        //    {
        //        await connection.OpenAsync();

        //        // Create a SqlCommand instance for your stored procedure
        //        using (var command = new SqlCommand("[FINA].[C2BPaymentValidationRequest]", connection))
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
        //                var results = new List<C2BPaymentValidationRequest>();

        //                while (await reader.ReadAsync())
        //                {
        //                    // Create instances of YourStoredProcResult and populate with data from reader
        //                    var result = new C2BPaymentValidationRequest
        //                    {
        //                        // Map reader columns to YourStoredProcResult properties
        //                        ResultCode = reader.GetInt32(reader.GetOrdinal("resultCode")),
        //                        ResultDesc = reader.GetString(reader.GetOrdinal("resultDesc")),
        //                        TransID = reader.GetString(reader.GetOrdinal("transID")),
        //                        BillRefNumber = reader.GetString(reader.GetOrdinal("billRefNumber")),
        //                        UtilityName = reader.GetString(reader.GetOrdinal("utilityName")),
        //                        CustomerName = reader.GetString(reader.GetOrdinal("customerName")),
        //                        Amount = reader.GetInt32(reader.GetOrdinal("amount"))

        //                    };

        //                    results.Add(result);
        //                }

        //                return results;
        //            }
        //        }
        //    }
        //}
        private async Task<C2BPaymentValidationRequestmap> ExecuteStoredProcedure(Dictionary<string, object> parameters)
        {
            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("[FINA].[C2BPaymentConfirmation]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters to the SqlCommand
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    // Add OUTPUT parameters to the SqlCommand
                    command.Parameters.Add(new SqlParameter("@ResultCode", SqlDbType.NVarChar, 4000) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResultDesc", SqlDbType.NVarChar, 4000) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@TransIDOutput", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@BillRefNumberOutput", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@UtilityName", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 300) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Float) { Direction = ParameterDirection.Output });

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    // Retrieve the OUTPUT parameters
                    var resultCode = command.Parameters["@ResultCode"].Value as string;
                    var resultDesc = command.Parameters["@ResultDesc"].Value as string;
                    var transIDOutput = command.Parameters["@TransIDOutput"].Value as string;
                    var billRefNumberOutput = command.Parameters["@BillRefNumberOutput"].Value as string;
                    var utilityName = command.Parameters["@UtilityName"].Value as string;
                    var customerName = command.Parameters["@CustomerName"].Value as string;
                    var amount = command.Parameters["@Amount"].Value;

                    // Check for DBNull and convert the amount to a double
                    var amountDouble = (amount != DBNull.Value) ? (double)amount : 0.0;

                    // Create a C2BPaymentQueryRequest instance to hold the output values
                    var result = new C2BPaymentValidationRequestmap
                    {
                        ResultCode = resultCode,
                        ResultDesc = resultDesc,
                        TransID = transIDOutput,
                        BillRefNumber = billRefNumberOutput,
                        UtilityName = utilityName,
                        CustomerName = customerName,
                        Amount = amountDouble
                    };

                    return result;
                }
            }
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
        //        var transAmount = doc.Descendants(web + "TransAmount").FirstOrDefault()?.Value;
        //        var invoiceNumber = doc.Descendants(web + "InvoiceNumber").FirstOrDefault()?.Value;
        //        var businessShortCode = doc.Descendants(web + "BusinessShortCode").FirstOrDefault()?.Value;
        //        var billRefNumber = doc.Descendants(web + "BillRefNumber").FirstOrDefault()?.Value;
        //        var msisdn = doc.Descendants(web + "MSISDN").FirstOrDefault()?.Value;
        //        var KYCInfo = doc.Descendants(web + "KYCInfo").FirstOrDefault()?.Value;


        //        parameters["@TransType"] = transType;
        //        parameters["@TransID"] = transID;
        //        parameters["@TransTime"] = transTime;
        //        parameters["@TransAmount"] = transAmount;
        //        parameters["@BusinessShortCode"] = businessShortCode;
        //        parameters["@BillRefNumber"] = billRefNumber;
        //        parameters["@InvoiceNumber"] = invoiceNumber;
        //        parameters["@MSISDN"] = msisdn;
        //        parameters["@KYCInfo"] = KYCInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any parsing exceptions
        //        // Log or handle the exception as needed
        //    }

        //    return parameters;
        //}

        private Dictionary<string, object> ParseSoapXml(string soapXml)
        {
            var parameters = new Dictionary<string, object>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(soapXml);

                // Create a namespace manager to handle namespaces
                XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
                namespaceManager.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                namespaceManager.AddNamespace("c2b", "http://cps.huawei.com/cpsinterface/c2bpayment");

                // Select and retrieve values using XPath
                var transID = xmlDoc.SelectSingleNode("//TransID", namespaceManager)?.InnerText;
                var transTime = xmlDoc.SelectSingleNode("//TransTime", namespaceManager)?.InnerText;
                var transAmount = xmlDoc.SelectSingleNode("//TransAmount", namespaceManager)?.InnerText;
                var businessShortCode = xmlDoc.SelectSingleNode("//BusinessShortCode", namespaceManager)?.InnerText;
                var invoiceNumber = xmlDoc.SelectSingleNode("//InvoiceNumber", namespaceManager)?.InnerText;
                var transType = xmlDoc.SelectSingleNode("//TransType", namespaceManager)?.InnerText;
                var billRefNumber = xmlDoc.SelectSingleNode("//BillRefNumber", namespaceManager)?.InnerText;
                var msisdn = xmlDoc.SelectSingleNode("//MSISDN", namespaceManager)?.InnerText;
          
                // Extract KYCInfo elements and concatenate them into a full name
                var kycInfoNodes = xmlDoc.SelectNodes("//KYCInfo", namespaceManager);
                string fullName = "";

                foreach (XmlNode kycInfoNode in kycInfoNodes)
                {
                    var kycValue = kycInfoNode.SelectSingleNode("//KYCValue", namespaceManager)?.InnerText;

                    if (!string.IsNullOrEmpty(kycValue))
                    {
                        fullName += kycValue + " ";
                    }
                }

                // Remove the trailing space
                fullName = fullName.Trim();

                // Add the extracted values to the dictionary
                parameters["@TransType"] = transType;
                parameters["@BillRefNumber"] = billRefNumber;
                parameters["@InvoiceNumber"] = invoiceNumber;
                parameters["@TransID"] = transID;
                parameters["@TransTime"] = transTime;
                parameters["@TransAmount"] = transAmount;
                parameters["@BusinessShortCode"] = businessShortCode;
                parameters["@MSISDN"] = msisdn;
                parameters["@KYCInfo"] = fullName;
            }
            catch (Exception ex)
            {
                // Handle any parsing exceptions
                // Log or handle the exception as needed
            }

            return parameters;
        }



        private string ConstructSoapResponse(C2BPaymentValidationRequestmap result)
        {
            // Define the namespaces
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace c2b = "http://cps.huawei.com/cpsinterface/c2bpayment";

            // Construct the SOAP response XML using the retrieved data
            var soapResponseXml = new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "soapenv", soapenv),
                new XAttribute(XNamespace.Xmlns + "c2b", c2b), // Add the c2b namespace
                new XElement(soapenv + "Header"),
                new XElement(soapenv + "Body",
                    new XElement(c2b + "C2BPaymentConfirmationResult", result.ResultCode
                        //new XElement("ResultCode", result.ResultCode)
                        //new XElement("ResultDesc", result.ResultDesc),
                        //new XElement("TransID", result.TransID),
                        //new XElement("BillRefNumber", result.BillRefNumber),
                        //new XElement("UtilityName", result.UtilityName),
                        //new XElement("CustomerName", result.CustomerName),
                        //new XElement("Amount", result.Amount)
                    // Add more fields as needed
                    )
                )
            ).ToString();

            return soapResponseXml;
        }



       


    }


}
