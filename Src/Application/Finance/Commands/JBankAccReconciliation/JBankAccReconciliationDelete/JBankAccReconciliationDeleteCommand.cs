 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.JBankAccReconciliation.JBankAccReconciliationDelete.JBankAccReconciliationDeleteCommand
{
     
    // @author  Henok Solomon  J_Bank_Acc_ReconciliationDelete stored procedure.
     
    #region J_Bank_Acc_ReconciliationDelete  
     
  /// J_Bank_Acc_ReconciliationDelete stored procedure.
     
    public class JBankAccReconciliationDeleteCommand : IRequest<IList<JBankAccReconciliation_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Transaction_Date { get; set; }
    }
		
        #endregion
		
		 
	}
 
 