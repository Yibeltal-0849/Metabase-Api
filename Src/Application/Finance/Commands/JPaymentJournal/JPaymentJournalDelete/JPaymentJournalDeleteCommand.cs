using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPaymentJournalDelete.JPaymentJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Payment_JournalDelete stored procedure.
	 
	#region J_Payment_JournalDelete  
     
  /// J_Payment_JournalDelete stored procedure.
     
        public class JPaymentJournalDeleteCommand : IRequest<IList<JPaymentJournal_Brnach_ID>>
    {

        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Account_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
