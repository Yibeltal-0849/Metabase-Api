using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOKA.WebUI.Model
{
    public class SoapC2BPaymentRequestModel
    {
        public string TransType { get; set; }
        public string TransID { get; set; }
        public string TransTime { get; set; }
        public string BusinessShortCode { get; set; }
        public string BillRefNumber { get; set; }
        public string MSISDN { get; set; }
    }
}
