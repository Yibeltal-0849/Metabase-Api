using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JSalesJournalDelete.JSalesJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Sales_JournalDelete stored procedure.
	 
	#region J_Sales_JournalDelete  
     
  /// J_Sales_JournalDelete stored procedure.
     
        public class JSalesJournalDeleteCommand : IRequest<IList<JSalesJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Account_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
