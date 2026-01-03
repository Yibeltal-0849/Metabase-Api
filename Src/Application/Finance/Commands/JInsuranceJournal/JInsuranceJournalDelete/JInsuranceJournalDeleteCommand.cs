using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JInsuranceJournalDelete.JInsuranceJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Insurance_JournalDelete stored procedure.
	 
	#region J_Insurance_JournalDelete  
     
  /// J_Insurance_JournalDelete stored procedure.
     
        public class JInsuranceJournalDeleteCommand : IRequest<IList<JInsuranceJournal_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public string Document_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
