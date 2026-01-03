using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
    public class SP_Bank_reconciliation_pay
    {
        public string Orderid { get; set; }
        public string? ResultCode { get; set; }
        public string? ResultDesc { get; set; }
        public string? TransID { get; set; }
        public string? BillRefNumber { get; set; }
        public string? UtilityName { get; set; }
        public string? CustomerName { get; set; }
        public string? Amount { get; set; }

    }

}
