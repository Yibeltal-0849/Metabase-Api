using System;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Purchase
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class SoapResponseEnvelopes
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public SoapHeader Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public SoapResponseBodyss Body { get; set; }
    }

    public class SoapResponseBodyss
    {
        [XmlElement(ElementName = "ResponseMsg", Namespace = "http://cps.huawei.com/cpsinterface/request")]
        public ResponseMsgss ResponseMessage { get; set; }
    }

    public class ResponseMsgss
    {
        [XmlText]
        public string CDATAContent { get; set; }
    }

    [XmlRoot(ElementName = "Result")]
    public class Result
    {
        [XmlElement("ResultType")]
        public int ResultType { get; set; }

        [XmlElement("ResultCode")]
        public int ResultCode { get; set; }

        [XmlElement("ResultDesc")]
        public string ResultDesc { get; set; }

        [XmlElement("OriginatorConversationIDs")]
        public string OriginatorConversationIDs { get; set; }

        [XmlElement("ConversationIDs")]
        public string ConversationIDs { get; set; }

        [XmlElement("TranactionID")]
        public string TranactionID { get; set; }

        [XmlElement("ResultParameters")]
        public string ResultParameters { get; set; }
    }

    public class B2CPaymentQueryResponsemap
    {
        public string CDATAContent { get; set; }
        public int ResultType { get; set; }

        
        public int ResultCode { get; set; }

       
        public string ResultDesc { get; set; }

        public string OriginatorConversationIDs { get; set; }
        public string ConversationIDs { get; set; }

    
        public string TranactionID { get; set; }

        public string ResultParameters { get; set; }
        public void Load(ResponseMsgss responseMsg, Result result)
        {
            if (responseMsg != null)
            {
                this.CDATAContent = responseMsg.CDATAContent;
            }

            if (result != null)
            {

                this.ResultType = result.ResultType;
                this.ResultCode = result.ResultCode;
                this.ResultDesc = result.ResultDesc;
                this.OriginatorConversationIDs = result.OriginatorConversationIDs;
                this.ConversationIDs = result.ConversationIDs;
                this.TranactionID = result.TranactionID;
                this.ResultParameters = result.ResultParameters;
    }
        }
    }
}
