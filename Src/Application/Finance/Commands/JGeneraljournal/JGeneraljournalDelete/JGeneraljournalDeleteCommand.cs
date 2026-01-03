using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JGeneraljournalDelete.JGeneraljournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_General_journalDelete stored procedure.
	 
	#region J_General_journalDelete  
     
  /// J_General_journalDelete stored procedure.
     
        public class JGeneraljournalDeleteCommand : IRequest<IList<JGeneralJournal_Brnach_ID>>
    {

        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_NO { get; set; }
        public string Account_Id { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
