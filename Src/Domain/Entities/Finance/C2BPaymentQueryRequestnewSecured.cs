using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class C2BPaymentQueryRequestnewSecured
    {
        [XmlElement(ElementName = "TransType", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public string TransType { get; set; }

        [XmlElement(ElementName = "TransID", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public string TransID { get; set; }

        [XmlElement(ElementName = "TransTime", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public string TransTime { get; set; }

        [XmlElement(ElementName = "BusinessShortCode", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public string BusinessShortCode { get; set; }

        [XmlElement(ElementName = "BillRefNumber", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public string BillRefNumber { get; set; }

        [XmlElement(ElementName = "MSISDN", Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
        public string MSISDN { get; set; }
    }

}
