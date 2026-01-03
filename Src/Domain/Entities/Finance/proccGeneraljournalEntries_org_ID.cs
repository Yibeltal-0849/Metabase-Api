using System;

namespace XOKA.Domain.Entities.Finance
{
    public class proccGeneraljournalEntries_org_ID
    {
        public System.Guid org_ID { get; set; }
        public System.Guid brnach_ID { get; set; }
        public DateTime dateDoc { get; set; }
        public string journal_Type { get; set; }
        public string document_No { get; set; }
    }
}
