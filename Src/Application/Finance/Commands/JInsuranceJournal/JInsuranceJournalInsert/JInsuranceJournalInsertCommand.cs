using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JInsuranceJournalInsert.JInsuranceJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Insurance_JournalInsert stored procedure.
	 
	#region J_Insurance_JournalInsert  
     
  /// J_Insurance_JournalInsert stored procedure.
     
        public class JInsuranceJournalInsertCommand : IRequest<IList<JInsuranceJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Insurance_No { get; set; }
        public string Fixed_Asset_No { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
