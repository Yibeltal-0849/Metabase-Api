using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.LVATLedgerEntries.LVATLedgerEntriesUpdate.LVATLedgerEntriesUpdateCommand
{

	/// @author  Shimels Alem  L_VAT_Ledger_ EntriesUpdate stored procedure.


	public class LVATLedgerEntriesUpdateCommand : IRequest<IList<LVatLedgerEntries_Branch_ID>>
   {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public long Entry_No { get; set; }
        public string VAT_Bus_Posting_Group { get; set; }
        public string VAT_Prod_Posting_Group { get; set; }
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
    }
		
		
		 
}

