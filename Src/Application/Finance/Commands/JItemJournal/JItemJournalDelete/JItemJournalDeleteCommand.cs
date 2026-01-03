using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemJournalDelete.JItemJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_JournalDelete stored procedure.
	 
	#region J_Item_JournalDelete  
     
  /// J_Item_JournalDelete stored procedure.
     
        public class JItemJournalDeleteCommand : IRequest<IList<JItemJournal_Branch_ID>>
    {
    
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
