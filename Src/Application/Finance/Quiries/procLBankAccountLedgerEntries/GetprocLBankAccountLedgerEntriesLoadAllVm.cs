using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procLBankAccountLedgerEntries
{
    public class GetprocLBankAccountLedgerEntriesLoadAllVm : IMapFrom<LBankAccountLedgerEntries>
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
        public void Mapping(Profile profile)
        {
            profile.CreateMap<LBankAccountLedgerEntries, GetprocLBankAccountLedgerEntriesLoadAllVm>();
        }
    }
}
