


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LFALedgerEntries.LFALedgerEntriesInsert.LFALedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_FA_Ledger_EntriesInsert stored procedure.


    public class LFALedgerEntriesInsertCommand : IRequest<IList<L_FA_Ledger_Entries_Branch_ID>>
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
	}
		
		
		 
}
 
 