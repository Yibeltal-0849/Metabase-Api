using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPaymentJournalInsert.JPaymentJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Payment_JournalInsert stored procedure.
	 
	#region J_Payment_JournalInsert  
     
  /// J_Payment_JournalInsert stored procedure.
     
        public class JPaymentJournalInsertCommand : IRequest<IList<JPaymentJournal_Brnach_ID>>
    {

        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string External_Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public string Currency_Code { get; set; }
        public decimal Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Applies_to_Doc_Type { get; set; }
        public string Applies_to_Doc_No { get; set; }
        public System.DateTime Applies_to_Doc_Due_Date { get; set; }
        public System.Guid Bank_Payment_Type { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
