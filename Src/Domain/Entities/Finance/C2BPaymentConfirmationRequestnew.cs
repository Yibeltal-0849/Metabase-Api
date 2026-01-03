using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class C2BPaymentConfirmationRequestEnvelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Bod1y1 Body { get; set; }
    }

    public class Bod1y1
    {
        [XmlElement(ElementName = "C2BPaymentConfirmationRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public C2BPaymentConfirmationRequest C2BPaymentConfirmationRequest { get; set; }
    }

   //[XmlRoot(ElementName = "C2BPaymentValidationRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public class C2BPaymentConfirmationRequest
    {
        public string? TransType { get; set; }
        public string? TransID { get; set; }
        public string? TransTime { get; set; }
        public Double? TransAmount { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? BusinessShortCode { get; set; }
        public string? BillRefNumber { get; set; }
        public string? MSISDN { get; set; }

        [XmlElement(ElementName = "KYCInfo")]
        public List<KYCInfo1> KYCInfo { get; set; }
    }

    [XmlRoot(ElementName = "KYCInfo")]
    public class KYCInfo1
    {
        public string? KYCName { get; set; }
        public string? KYCValue { get; set; }
    }

}
