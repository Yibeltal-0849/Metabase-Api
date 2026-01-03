using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procLWHTLedgerEntries
{
    public class GetprocLWHTLedgerEntriesLoadAllVm : IMapFrom<L_WHT_Ledger_Entries>
    {

		public System.Guid Branch_ID { get; set; }
		public System.DateTime Period { get; set; }
		public System.Int64 Entry_No { get; set; }
		public string WHT_Bus_Posting_Group { get; set; }
		public string WHT_Prod_Posting_Group { get; set; }
		public System.DateTime? Posting_Date { get; set; }
		public string Document_No { get; set; }
		public string Document_Type { get; set; }
		public string Type { get; set; }
		public double? Base { get; set; }
		public double? Amount { get; set; }
		public string Bill_to_Pay_to_No { get; set; }
		public string Country_Region_Code { get; set; }
		public bool? Closed { get; set; }
		public string Closed_by_Entry_No { get; set; }
		public string Internal_Ref_No { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<L_WHT_Ledger_Entries, GetprocLWHTLedgerEntriesLoadAllVm>();
        }
    }
}
