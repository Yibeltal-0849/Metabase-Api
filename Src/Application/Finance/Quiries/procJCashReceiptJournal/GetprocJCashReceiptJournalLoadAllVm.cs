using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJCashReceiptJournal
{
    public class GetprocJCashReceiptJournalLoadAllVm : IMapFrom<JCashReceiptJournal>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_AccountNo { get; set; }
        public string Applies_to_Doc_Type { get; set; }
        public string Applies_to_Doc_No { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<JCashReceiptJournal, GetprocJCashReceiptJournalLoadAllVm>();
        }
    }
}
