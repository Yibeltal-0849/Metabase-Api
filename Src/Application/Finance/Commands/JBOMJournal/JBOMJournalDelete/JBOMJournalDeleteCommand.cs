using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JBOMJournal.JBOMJournalDelete.JBOMJournalDeleteCommand
{

    /// @author  Henok Solomon  J_BOM_JournalDelete stored procedure.

    #region J_JOB_JournalDelete  

    /// J_BOM_JournalDelete stored procedure.

    public class JBOMJournalDeleteCommand : IRequest<IList<JBomJournal_PostingDate>>
    {
    
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
