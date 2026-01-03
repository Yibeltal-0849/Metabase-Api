using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
   public  class C2BPaymentValidationRequestmap
    {

        [XmlElement("ResultCode")]
        public string? ResultCode { get; set; }
       
        [XmlElement("ResultDesc")]
        public string? ResultDesc { get; set; }
        [XmlElement("TransID")]
        public string? TransID { get; set; }
        [XmlElement("BillRefNumber")]
        public string? BillRefNumber { get; set; }

        [XmlElement("UtilityName")]
        public string? UtilityName { get; set; }

        [XmlElement("CustomerName")]
        public string? CustomerName { get; set; }
        [XmlElement("Amount")]
        public double? Amount { get; set; }


    }
}
