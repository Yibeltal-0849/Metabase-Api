using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemReclassJournalInsert.JItemReclassJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_Reclass_JournalInsert stored procedure.
	 
	#region J_Item_Reclass_JournalInsert  
     
  /// J_Item_Reclass_JournalInsert stored procedure.
     
        public class JItemReclassJournalInsertCommand : IRequest<IList<JItemReclassJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public string UnitofMeasureCode { get; set; }
        public bool? Applies_to_Entry { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
