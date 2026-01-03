using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
   public  class C2BPaymentValidationRequest
    {

        [XmlElement("TransType")]
        public string? TransType { get; set; }

        [XmlElement("TransID")]
        public string? TransID { get; set; }

        [XmlElement("TransTime")]
        public string? TransTime { get; set; }
    
        [XmlElement("TransAmount")]
        public string? TransAmount { get; set; }

        [XmlElement("BusinessShortCode")]
        public string? BusinessShortCode { get; set; }

        [XmlElement("ThirdPartyTransID")]
        public string? ThirdPartyTransID { get; set; } 

        [XmlElement("BillRefNumber")]
        public string? BillRefNumber { get; set; }
        [XmlElement("InvoiceNumber")]
        public string InvoiceNumber { get; set; }

        [XmlElement("MSISDN")]
        public string? MSISDN { get; set; }

        [XmlElement("KYCInfo")]
        public string? KYCInfo { get; set; }
     
     
        [XmlElement("ResultCode")]
        public string? ResultCode { get; set; }
       
        [XmlElement("ResultDesc")]
        public string? ResultDesc { get; set; }
      
        [XmlElement("UtilityName")]
        public string? UtilityName { get; set; }

        [XmlElement("Amount")]
        public float? Amount { get; set; }

        [XmlElement("CustomerName")]
        public string? CustomerName { get; set; }

        
    }
}
