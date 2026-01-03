using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JFixedAssetJournalUpdate.JFixedAssetJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Fixed_Asset_JournalUpdate stored procedure.
	 
	#region J_Fixed_Asset_JournalUpdate  
     
  /// J_Fixed_Asset_JournalUpdate stored procedure.
     
        public class JFixedAssetJournalUpdateCommand : IRequest<IList<JFixedAssetJournal_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string FA_No { get; set; }
        public string Book_Code { get; set; }
        public string FA_Posting_Type { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public int Year { get; set; }
        public System.DateTime? Period { get; set; }
        public string GL_EnteryNO { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
