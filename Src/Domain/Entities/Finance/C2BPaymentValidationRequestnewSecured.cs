using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeSecured
    {
       

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body1 Body { get; set; }
    }


    public class Body1

    {
        [XmlElement("Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Header1 Header { get; set; }

        [XmlElement("C2BPaymentValidationRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public C2BPaymentValidationRequest C2BPaymentValidationRequest { get; set; }
    }
    [XmlRoot(ElementName = "Header", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public class Header1
    {
       
        public string CommandID { get; set; }

     
        public string Version { get; set; }

        public string LoginID { get; set; }

      
        public string Password { get; set; }

       
        public string Timestamp { get; set; }
    }
    [XmlRoot(ElementName = "C2BPaymentValidationRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public class C2BPaymentValidationRequestnewSecured
    {
        public string? TransType { get; set; }
        public string? TransID { get; set; }
        public string? TransTime { get; set; }
        public int? TransAmount { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? BusinessShortCode { get; set; }
        public string? BillRefNumber { get; set; }
        public string? MSISDN { get; set; }
        public List<KYCInfos1> KYCInfo1 { get; set; }
    }
    
    public class KYCInfos1
    {
        public string? KYCName { get; set; }
        public string? KYCValue { get; set; }
    }

}
