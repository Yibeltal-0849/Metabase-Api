using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class C2BPaymentValidationRequestEnvelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Bod1y Body { get; set; }
    }

    public class Bod1y
    {
        [XmlElement(ElementName = "C2BPaymentValidationRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public C2BPaymentValidationRequestnew C2BPaymentValidationRequest { get; set; }
    }

   //[XmlRoot(ElementName = "C2BPaymentValidationRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public class C2BPaymentValidationRequestnew
    {
        public string? TransType { get; set; }
        public string? TransID { get; set; }
        public string? TransTime { get; set; }
        public  Double? TransAmount { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? BusinessShortCode { get; set; }
        public string? BillRefNumber { get; set; }
        public string? MSISDN { get; set; }

        [XmlElement(ElementName = "KYCInfo")]
        public List<KYCInfo> KYCInfo { get; set; }
    }

    [XmlRoot(ElementName = "KYCInfo")]
    public class KYCInfo
    {
        public string? KYCName { get; set; }
        public string? KYCValue { get; set; }
    }

}
