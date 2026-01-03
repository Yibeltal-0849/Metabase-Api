using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemReclassJournalDelete.JItemReclassJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_Reclass_JournalDelete stored procedure.
	 
	#region J_Item_Reclass_JournalDelete  
     
  /// J_Item_Reclass_JournalDelete stored procedure.
     
        public class JItemReclassJournalDeleteCommand : IRequest<IList<JItemReclassJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
