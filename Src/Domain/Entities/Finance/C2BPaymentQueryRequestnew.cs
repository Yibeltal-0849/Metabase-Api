using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


//    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
//    public class C2BPaymentQueryRequestnew
//    {
//        [XmlElement(ElementName = "TransType", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
//        public string TransType { get; set; }

//        [XmlElement(ElementName = "TransID", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
//        public string TransID { get; set; }

//        [XmlElement(ElementName = "TransTime", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
//        public string TransTime { get; set; }

//        [XmlElement(ElementName = "BusinessShortCode", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
//        public string BusinessShortCode { get; set; }

//        [XmlElement(ElementName = "BillRefNumber", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
//        public string BillRefNumber { get; set; }

//        [XmlElement(ElementName = "MSISDN", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
//        public string MSISDN { get; set; }
//    }

//}

namespace XOKA.Domain.Entities.Finance
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class C2BPaymentQueryRequestEnvelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "C2BPaymentQueryRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public C2BPaymentQueryRequest C2BPaymentQueryRequest { get; set; }
    }
    [XmlRoot(ElementName = "C2BPaymentQueryRequest", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public class C2BPaymentQueryRequest
    {
        [XmlElement(ElementName = "TransType")]
        public string TransType { get; set; }

        [XmlElement(ElementName = "TransID")]
        public string TransID { get; set; }

        [XmlElement(ElementName = "TransTime")]
        public string TransTime { get; set; }

        [XmlElement(ElementName = "BusinessShortCode")]
        public string BusinessShortCode { get; set; }

        [XmlElement(ElementName = "BillRefNumber")]
        public string BillRefNumber { get; set; }

        [XmlElement(ElementName = "MSISDN")]
        public string MSISDN { get; set; }
    }
}


  



