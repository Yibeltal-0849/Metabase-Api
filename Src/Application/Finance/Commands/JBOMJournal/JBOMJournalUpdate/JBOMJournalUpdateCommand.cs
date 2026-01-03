using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JBOMJournal.JBOMJournalUpdate.JBOMJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_BOM_JournalUpdate stored procedure.
	 
	#region J_BOM_JournalUpdate  
     
  /// J_BOM_JournalUpdate stored procedure.
     
        public class JBOMJournalUpdateCommand : IRequest<IList<JBomJournal_PostingDate>>
    {
        public string Posting_Date { get; set; }
        public string DocumentNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public string Quantity { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string UnitCost { get; set; }
        public string TotalCost { get; set; }
    }
		
        #endregion
		
		 
	}
 
 