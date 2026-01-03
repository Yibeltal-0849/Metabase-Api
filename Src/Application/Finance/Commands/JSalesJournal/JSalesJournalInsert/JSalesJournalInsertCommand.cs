using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JSalesJournalInsert.JSalesJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Sales_JournalInsert stored procedure.
	 
	#region J_Sales_JournalInsert  
     
  /// J_Sales_JournalInsert stored procedure.
     
        public class JSalesJournalInsertCommand : IRequest<IList<JSalesJournal_Branch_ID>>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public string Gen_Posting_Type { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public decimal? Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Bal_Gen_Posting_Type { get; set; }
        public string Bal_Gen_Bus_Posting_Group { get; set; }
        public string Bal_Gen_Prod_Posting_Group { get; set; }
        public string Applies_to_Doc_Type { get; set; }
        public string Applies_to_Doc_No { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
