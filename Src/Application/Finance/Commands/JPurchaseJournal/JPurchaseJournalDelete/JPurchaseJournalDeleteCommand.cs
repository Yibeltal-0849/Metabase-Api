using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPurchaseJournalDelete.JPurchaseJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Purchase_JournalDelete stored procedure.
	 
	#region J_Purchase_JournalDelete  
     
  /// J_Purchase_JournalDelete stored procedure.
     
        public class JPurchaseJournalDeleteCommand : IRequest<IList<JPurchaseJournal_Org_ID>>
    {
        public System.Guid Org_ID { get; set; }
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }

    }

    #endregion


}
 
 
