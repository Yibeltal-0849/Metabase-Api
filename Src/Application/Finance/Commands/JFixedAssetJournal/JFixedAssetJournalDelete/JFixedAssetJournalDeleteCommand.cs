using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JFixedAssetJournalDelete.JFixedAssetJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Fixed_Asset_JournalDelete stored procedure.
	 
	#region J_Fixed_Asset_JournalDelete  
     
  /// J_Fixed_Asset_JournalDelete stored procedure.
     
        public class JFixedAssetJournalDeleteCommand : IRequest<IList<JFixedAssetJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string FA_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
