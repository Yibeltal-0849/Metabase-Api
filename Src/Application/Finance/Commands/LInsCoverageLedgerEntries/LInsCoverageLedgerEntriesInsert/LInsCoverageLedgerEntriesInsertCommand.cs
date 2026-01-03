


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LInsCoverageLedgerEntries.LInsCoverageLedgerEntriesInsert.LInsCoverageLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_Ins_Coverage_Ledger_EntriesInsert stored procedure.


    public class LInsCoverageLedgerEntriesInsertCommand : IRequest<IList<L_Ins_Coverage_Ledger_Entries_Branch_ID>>
    {
		public System.Guid Branch_ID { get; set; }
		public System.DateTime Period { get; set; }
		public string PostingDate { get; set; }
		public string DocumentType { get; set; }
		public string DocumentNo { get; set; }
		public string InsuranceNo { get; set; }
		public string FANo { get; set; }
		public string Description { get; set; }
		public double? Amount { get; set; }
		public bool? DisposedFA { get; set; }
		public System.Int64 EntryNo { get; set; }
	}
		
		
		 
}
 
 