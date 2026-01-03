using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JBankAccReconciliation.JBankAccReconciliationUpdate.JBankAccReconciliationUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationUpdate stored procedure.
	 
	#region J_Bank_Acc_ReconciliationUpdate  
    
 /// J_Bank_Acc_ReconciliationUpdate stored procedure.
    
       public class JBankAccReconciliationUpdateCommand : IRequest<IList<JBankAccReconciliation_Branch_ID>>
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

