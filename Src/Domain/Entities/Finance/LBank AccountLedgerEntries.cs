using System;

namespace XOKA.Domain.Entities.Finance
{
    public class LBankAccountLedgerEntries
    {
        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public Nullable<System.DateTime> Period { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Bank_Account_No { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Nullable<bool> Open { get; set; }
        public Nullable<int> Entry_No { get; set; }
    }
}
