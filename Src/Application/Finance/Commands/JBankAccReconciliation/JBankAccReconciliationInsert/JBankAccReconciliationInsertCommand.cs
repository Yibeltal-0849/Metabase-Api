


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.JBankAccReconciliation.JBankAccReconciliationInsert.JBankAccReconciliationInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationInsert stored procedure.
	 
	#region J_Bank_Acc_ReconciliationInsert  
     
  /// J_Bank_Acc_ReconciliationInsert stored procedure.
     
        public class JBankAccReconciliationInsertCommand : IRequest<IList<JBankAccReconciliation_Branch_ID>>
    {


        public System.Guid Branch_ID { get; set; }
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Transaction_Date { get; set; }
        public System.Guid Type_Bank_Reconcilliation { get; set; }
        public string Description { get; set; }
        public decimal? Statement_Amount { get; set; }
        public decimal Applied_Amount { get; set; }
        public decimal? Difference { get; set; }
        public string Document_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 