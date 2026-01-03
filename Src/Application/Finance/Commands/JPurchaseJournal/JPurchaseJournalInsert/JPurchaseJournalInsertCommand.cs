using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPurchaseJournalInsert.JPurchaseJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Purchase_JournalInsert stored procedure.
	 
	#region J_Purchase_JournalInsert  
     
  /// J_Purchase_JournalInsert stored procedure.
     
        public class JPurchaseJournalInsertCommand : IRequest<IList<JPurchaseJournal_Org_ID>>
    {

        public System.Guid Org_ID { get; set; }
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public string Gen_Posting_Type { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public decimal Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Bal_Gen_Posting_Type { get; set; }
        public string Bal_Gen_Bus_Posting_Group { get; set; }
        public string Bal_Gen_Prod_Posting_Group { get; set; }
        public decimal Bal_Amount { get; set; }
        public string Applies_to_Doc_Type { get; set; }
        public string Applies_to_Doc_No { get; set; }
        public bool? On_Hold { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
