


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.JCashReceiptJournal.JCashReceiptJournalInsert.JCashReceiptJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationInsert stored procedure.
	 
	#region J_Bank_Acc_ReconciliationInsert  
     
  /// J_Bank_Acc_ReconciliationInsert stored procedure.
     
        public class JCashReceiptJournalInsertCommand : IRequest<IList<JCashReceiptJournal_Branch_ID>>
    {

		public Guid Branch_ID { get; set; }
		public DateTime Posting_Date { get; set; }
		public string Document_Type { get; set; }
		public string Document_No { get; set; }
		public string Account_Type { get; set; }
		public string Account_No { get; set; }
		public string Description { get; set; }
		public Double Amount { get; set; }
		public string Bal_Account_Type { get; set; }
		public string Bal_AccountNo { get; set; }
		public string Applies_to_Doc_Type { get; set; }
		public string Applies_to_Doc_No { get; set; }

    }
		
        #endregion
		
		 
	}
 
 