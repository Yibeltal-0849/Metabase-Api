using System;

namespace XOKA.Domain.Entities.view
{
    public  class View_bank_reco_list
    {
        public string Orderid { get; set; }
        public DateTime? trans_initate_time { get; set; }
        public string? top_short_code { get; set; }
        public string? short_code { get; set; }
        public string biz_org_name { get; set; }
        public string? trans_status { get; set; }
        public string? debit_party_mnemonic { get; set; }
        public decimal? Amount { get; set; }
        public string? BillReferenceNumber { get; set; }
        public string? bank_name { get; set; }
        public string? Mobile_No { get; set; }

    }
}
