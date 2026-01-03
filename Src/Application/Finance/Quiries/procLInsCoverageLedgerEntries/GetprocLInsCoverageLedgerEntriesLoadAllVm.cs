using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procLInsCoverageLedgerEntries
{
    public class GetprocLInsCoverageLedgerEntriesLoadAllVm : IMapFrom<L_Ins_Coverage_Ledger_Entries>
    {
		public System.Guid Branch_ID { get; set; }
		public System.DateTime Period { get; set; }
		public string Posting_Date { get; set; }
		public string Document_Type { get; set; }
		public string Document_No { get; set; }
		public string Insurance_No { get; set; }
		public string FA_No { get; set; }
		public string Description { get; set; }
		public double? Amount { get; set; }
		public bool? Disposed_FA { get; set; }
		public System.Int64 Entry_No { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<L_Ins_Coverage_Ledger_Entries, GetprocLInsCoverageLedgerEntriesLoadAllVm>();
        }
    }
}
