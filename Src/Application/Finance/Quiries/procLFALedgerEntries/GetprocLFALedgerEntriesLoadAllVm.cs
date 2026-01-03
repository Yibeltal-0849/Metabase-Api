using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procLFALedgerEntries
{
    public class GetprocLFALedgerEntriesLoadAllVm : IMapFrom<L_FA_Ledger_Entries>
    {
		public System.Guid Branch_ID { get; set; }
		public System.DateTime Period { get; set; }
		public System.DateTime FA_Posting_Date { get; set; }
		public string Document_Type { get; set; }
		public string Document_No { get; set; }
		public string FA_No { get; set; }
		public string FA_Posting_Category { get; set; }
		public string FA_Posting_Type { get; set; }
		public string Description { get; set; }
		public double Amount { get; set; }
		public string Reclassification_Entry { get; set; }
		public System.Int32 No_of_Depreciation_Days { get; set; }
		public System.DateTime Posting_Date { get; set; }
		public System.Int64 G_or_L_Entry_No { get; set; }
		public System.Int64 Entry_No { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<L_FA_Ledger_Entries, GetprocLFALedgerEntriesLoadAllVm>();
        }
    }
}
