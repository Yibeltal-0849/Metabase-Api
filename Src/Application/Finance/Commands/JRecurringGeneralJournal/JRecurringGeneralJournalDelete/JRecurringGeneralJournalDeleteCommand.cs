using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JRecurringGeneralJournalDelete.JRecurringGeneralJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Recurring_General_JournalDelete stored procedure.
	 
	#region J_Recurring_General_JournalDelete  
     
  /// J_Recurring_General_JournalDelete stored procedure.
     
        public class JRecurringGeneralJournalDeleteCommand : IRequest<IList<JRecurringGeneralJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Account_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
