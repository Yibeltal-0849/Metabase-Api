using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOKA.WebUI.Model
{
    public class transactionpurchase
    {
        public string No { get; set; }
        public System.Guid? Org_Code { get; set; }
        public string Vendor_ID { get; set; }
        public string Type { get; set; }
        public string Contract_No { get; set; }
        public System.DateTime? Date { get; set; }
        public string Vendor_Invoice_No { get; set; }
        public string Application_No { get; set; }
        public System.Guid? Application_Code { get; set; }
        public System.Guid? Service_Code { get; set; }
        public string Service_Name { get; set; }
        public System.Guid? Parent_Application_Code { get; set; }
        public string Parent_Application_No { get; set; }
        public string Vendor_Cr_Memo_No { get; set; }
        public string Vendor_Authorization_No { get; set; }
        public System.DateTime? Document_Date { get; set; }
        public System.DateTime? Posting_Date { get; set; }
        public string Vendor_Name { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string Payment_Terms_Code { get; set; }
        public string TAX_Bus_Posting_group { get; set; }
        public bool? Price_Including_VAT { get; set; }
        public System.DateTime? Pmt_Discount_Date { get; set; }
        public System.DateTime? Due_Date { get; set; }
        public bool? Paid_Bank_Chack { get; set; }
    }
}
