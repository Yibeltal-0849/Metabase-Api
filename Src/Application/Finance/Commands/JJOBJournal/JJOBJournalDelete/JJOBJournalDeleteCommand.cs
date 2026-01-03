using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJOBJournalDelete.JJOBJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_JOB_JournalDelete stored procedure.
	 
	#region J_JOB_JournalDelete  
     
  /// J_JOB_JournalDelete stored procedure.
     
        public class JJOBJournalDeleteCommand : IRequest<IList<JJobJournal_Branch_ID>>
    {
    
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
