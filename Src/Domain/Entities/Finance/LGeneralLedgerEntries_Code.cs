using System;

namespace XOKA.Domain.Entities.Finance
{
    public class LGeneralLedgerEntries_Code
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
    }
}
