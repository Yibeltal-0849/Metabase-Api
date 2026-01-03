using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Purchase
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class B2CPaymentQueryResponsenew
    {
        [XmlElement(ElementName = "ResponseCode", Namespace = "http://cps.huawei.com/cpsinterface/b2cpayment")]
        public int ResponseCode { get; set; }

        [XmlElement(ElementName = "ResponseDesc", Namespace = "http://cps.huawei.com/cpsinterface/b2cpayment")]
        public string ResponseDesc { get; set; }

        [XmlElement(ElementName = "OriginatorConversationID", Namespace = "http://cps.huawei.com/cpsinterface/b2cpayment")]
        public string OriginatorConversationID { get; set; }

        [XmlElement(ElementName = "ConversationID", Namespace = "http://cps.huawei.com/cpsinterface/b2cpayment")]
        public string ConversationID { get; set; }

        [XmlElement(ElementName = "ServiceStatus", Namespace = "http://cps.huawei.com/cpsinterface/b2cpayment")]
        public string ServiceStatus { get; set; }

    }

}
