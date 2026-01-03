using System;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Purchase
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class SoapResponseEnvelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public SoapHeader Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public SoapResponseBody Body { get; set; }
    }

    public class SoapResponseBody
    {
        [XmlElement(ElementName = "ResponseMsg", Namespace = "http://cps.huawei.com/cpsinterface/request")]
        public ResponseMsg ResponseMessage { get; set; }
    }

    public class ResponseMsg
    {
        [XmlText]
        public string CDATAContent { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class Response
    {
        [XmlElement(ElementName = "ResponseCode")]
        public int ResponseCode { get; set; }

        [XmlElement(ElementName = "ResponseDesc")]
        public string ResponseDesc { get; set; }

        [XmlElement(ElementName = "OriginatorConversationID")]
        public string OriginatorConversationID { get; set; }

        [XmlElement(ElementName = "ConversationID")]
        public string ConversationID { get; set; }

        [XmlElement(ElementName = "ServiceStatus")]
        public string ServiceStatus { get; set; }
    }

    public class B2CPaymentQueryRequestmap
    {
        public string CDATAContent { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseDesc { get; set; }
        public string OriginatorConversationID { get; set; }
        public string ConversationID { get; set; }
        public string ServiceStatus { get; set; }

        public void Load(ResponseMsg responseMsg, Response response)
        {
            if (responseMsg != null)
            {
                this.CDATAContent = responseMsg.CDATAContent;
            }

            if (response != null)
            {
                this.ResponseCode = response.ResponseCode;
                this.ResponseDesc = response.ResponseDesc;
                this.OriginatorConversationID = response.OriginatorConversationID;
                this.ConversationID = response.ConversationID;
                this.ServiceStatus = response.ServiceStatus;
            }
        }
    }
}
