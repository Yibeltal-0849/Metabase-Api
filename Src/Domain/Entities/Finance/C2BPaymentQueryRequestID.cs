using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Finance
{
   public  class C2BPaymentQueryRequestID
    {
        public string TransType { get; set; }
        public string TransID { get; set; }
        public string TransTime { get; set; }
        public string BusinessShortCode { get; set; }
        public string BillRefNumber { get; set; }
        public string MSISDN { get; set; }

    }
}
