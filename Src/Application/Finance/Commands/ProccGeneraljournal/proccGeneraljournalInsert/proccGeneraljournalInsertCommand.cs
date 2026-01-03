using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalInsert.proccGeneraljournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journalInsert stored procedure.
	 
	#region proc_c_General_journalInsert  
     
  /// proc_c_General_journalInsert stored procedure.
     
        public class proccGeneraljournalInsertCommand : IRequest<IList<proccGeneraljournal_account_Id>>
    {
    
		public System.Guid  org_ID  { get; set; }
		public System.Guid  brnach_ID  { get; set; }
		public DateTime  dateDoc  { get; set; }
		public string  account_Id  { get; set; }
		public string  document_NO  { get; set; }
		public string  journal_Type  { get; set; }
		public string  account_Type  { get; set; }
		public string  description  { get; set; }
		public long?  gL_Budget_ID  { get; set; }
		public string  c_Currency_ID  { get; set; }
		public decimal  amount  { get; set; }
		public decimal  controlAmt  { get; set; }
		public string  bal_Account_No  { get; set; }
		public string  bal_Journal_Type  { get; set; }
		public string  bal_Account_Type  { get; set; }
		public decimal  bal_Amount  { get; set; }
		public decimal  bal_ControlAmt  { get; set; }
		public string  remark  { get; set; }
		public bool?  processing  { get; set; }
		public bool?  processed  { get; set; }
		public bool?  posted  { get; set; }
		public DateTime c_Period_ID  { get; set; }
		public string document_Type  { get; set; }
		public string bal_Document_Type  { get; set; }
		public string bal_Document_No { get; set; }
		public string Gen_Posting_Type { get; set; }
		public string Gen_Bus_Posting_Group { get; set; } 
		public string Gen_Prod_Posting_Group { get; set; }
		public string bal_Gen_Posting_Type { get; set; }
		public string bal_Gen_Bus_Posting_Group { get; set; }
		public string Bal_Gen_Prod_Posting_Group { get; set; }
		public string Log { get; set; }
	}
		
        #endregion
		
		 
	}
 
 
