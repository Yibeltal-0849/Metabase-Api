using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Purchase
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class SoapEnvelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public SoapHeader Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public SoapBody Body { get; set; }
    }

    public class SoapHeader
    {
    }

    public class SoapBody
    {
        [XmlElement(ElementName = "RequestMsg", Namespace = "http://cps.huawei.com/cpsinterface/request")]
        public RequestMsg RequestMessage { get; set; }
    }

    public class RequestMsg
    {
        [XmlText]
        public string CDATAContent { get; set; }
    }

    [XmlRoot(ElementName = "Request")]
    public class B2CPaymentQueryRequestnew
    {
        [XmlElement(ElementName = "KeyOwner")]
        public int KeyOwner { get; set; }

        [XmlElement(ElementName = "Identity")]
        public Identity Identity { get; set; }

        [XmlElement(ElementName = "Transaction")]
        public Transaction Transaction { get; set; }
    }

    public class Identity
    {
        [XmlElement(ElementName = "Caller")]
        public Caller Caller { get; set; }

        [XmlElement(ElementName = "Initiator")]
        public Initiator Initiator { get; set; }

        [XmlElement(ElementName = "ReceiverParty")]
        public ReceiverParty ReceiverParty { get; set; }
    }

    public class Caller
    {
        [XmlElement(ElementName = "CallerType")]
        public int CallerType { get; set; }

        [XmlElement(ElementName = "ThirdPartyID")]
        public string ThirdPartyID { get; set; }

        [XmlElement(ElementName = "Password")]
        public string Password { get; set; }

        [XmlElement(ElementName = "ResultURL")]
        public string ResultURL { get; set; }
    }

    public class Initiator
    {
        [XmlElement(ElementName = "IdentifierType")]
        public int IdentifierType { get; set; }

        [XmlElement(ElementName = "Identifier")]
        public string Identifier { get; set; }

        [XmlElement(ElementName = "SecurityCredential")]
        public string SecurityCredential { get; set; }

        [XmlElement(ElementName = "ShortCode")]
        public string ShortCode { get; set; }
    }

    public class ReceiverParty
    {
        [XmlElement(ElementName = "IdentifierType")]
        public int IdentifierType { get; set; }

        [XmlElement(ElementName = "Identifier")]
        public string Identifier { get; set; }
    }

    public class Transaction
    {
        [XmlElement(ElementName = "CommandID")]
        public string CommandID { get; set; }

        [XmlElement(ElementName = "Timestamp")]
        public string Timestamp { get; set; }

        [XmlArray(ElementName = "Parameters")]
        [XmlArrayItem(ElementName = "Parameter")]
        public List<Parameter> Parameters { get; set; }

        [XmlElement(ElementName = "ReferenceData")]
        public ReferenceData ReferenceData { get; set; }
    }

    public class Parameter
    {
        [XmlElement(ElementName = "Key")]
        public string Key { get; set; }

        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
    }

    public class ReferenceData
    {
        [XmlElement(ElementName = "ReferenceItem")]
        public List<ReferenceItem> ReferenceItems { get; set; }
    }

    public class ReferenceItem
    {
        [XmlElement(ElementName = "Key")]
        public string Key { get; set; }

        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
    }

    public class MainClass
    {
        public string CDATAContent { get; set; }
        public int KeyOwner { get; set; }
        public int CallerType { get; set; }
        public string ThirdPartyID { get; set; }
        public string Password { get; set; }
        public string ResultURL { get; set; }
        public int IdentifierType { get; set; }
        public string Identifier { get; set; }
        public string SecurityCredential { get; set; }
        public string ShortCode { get; set; }
        public int ReceiverIdentifierType { get; set; }
        public string ReceiverIdentifier { get; set; }
        public string CommandID { get; set; }
        public string Timestamp { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Key1 { get; set; }
        public string Value1 { get; set; }

        public void Load(RequestMsg requestMsg, B2CPaymentQueryRequestnew B2CPaymentQueryRequestnew)
        {
            if (requestMsg != null)
            {
                this.CDATAContent = requestMsg.CDATAContent;
                this.KeyOwner = B2CPaymentQueryRequestnew.KeyOwner;
                this.CallerType = B2CPaymentQueryRequestnew.Identity.Caller.CallerType;
                this.ThirdPartyID = B2CPaymentQueryRequestnew.Identity.Caller.ThirdPartyID;
                this.Password = B2CPaymentQueryRequestnew.Identity.Caller.Password;
                this.ResultURL = B2CPaymentQueryRequestnew.Identity.Caller.ResultURL;
                this.IdentifierType = B2CPaymentQueryRequestnew.Identity.Initiator.IdentifierType;
                this.Identifier = B2CPaymentQueryRequestnew.Identity.Initiator.Identifier;
                this.SecurityCredential = B2CPaymentQueryRequestnew.Identity.Initiator.SecurityCredential;
                this.ShortCode = B2CPaymentQueryRequestnew.Identity.Initiator.ShortCode;
                this.ReceiverIdentifierType = B2CPaymentQueryRequestnew.Identity.ReceiverParty.IdentifierType;
                this.ReceiverIdentifier = B2CPaymentQueryRequestnew.Identity.ReceiverParty.Identifier;
                this.CommandID = B2CPaymentQueryRequestnew.Transaction.CommandID;
                this.Timestamp = B2CPaymentQueryRequestnew.Transaction.Timestamp;

                if (B2CPaymentQueryRequestnew.Transaction.Parameters != null &&
                    B2CPaymentQueryRequestnew.Transaction.Parameters.Count > 0)
                {
                    this.Key = B2CPaymentQueryRequestnew.Transaction.Parameters[0].Key;
                    this.Value = B2CPaymentQueryRequestnew.Transaction.Parameters[0].Value;
                }

                if (B2CPaymentQueryRequestnew.Transaction.ReferenceData?.ReferenceItems != null &&
                    B2CPaymentQueryRequestnew.Transaction.ReferenceData.ReferenceItems.Count > 0)
                {
                    this.Key1 = B2CPaymentQueryRequestnew.Transaction.ReferenceData.ReferenceItems[0].Key;
                    this.Value1 = B2CPaymentQueryRequestnew.Transaction.ReferenceData.ReferenceItems[0].Value;
                }
            }
        }
    }
}
