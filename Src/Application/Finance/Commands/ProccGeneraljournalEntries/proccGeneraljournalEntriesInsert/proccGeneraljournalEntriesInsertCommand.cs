using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalEntriesInsert.proccGeneraljournalEntriesInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journal_Entries Insert stored procedure.
	 
	#region proc_c_General_journal_Entries Insert  
     
  /// proc_c_General_journal_Entries Insert stored procedure.
     
        public class proccGeneraljournalEntriesInsertCommand : IRequest<IList<proccGeneraljournalEntries_org_ID>>
    {
    
		public System.Guid  org_ID  { get; set; }
		public System.Guid  brnach_ID  { get; set; }
		public DateTime  dateDoc  { get; set; }
		public string  document_Type  { get; set; }
		public string  account_No  { get; set; }
		public string  journal_Type  { get; set; }
		public string  document_No  { get; set; }
		public string  account_Type  { get; set; }
		public string  description  { get; set; }
		public string  c_Currency_ID  { get; set; }
		public decimal?  amount  { get; set; }
		public double?  controlAmt  { get; set; }
		public string  bal_Document_Type  { get; set; }
		public string  bal_Account_No  { get; set; }
		public string  bal_Journal_Type  { get; set; }
		public string  bal_Account_Type  { get; set; }
		public decimal?  bal_Amount  { get; set; }
		public decimal?  bal_ControlAmt  { get; set; }
		public string  bal_Document_No  { get; set; }
		public string  remark  { get; set; }
		public bool?  processing  { get; set; }
		public bool?  processed  { get; set; }
		public bool?  posted  { get; set; }
		public DateTime?  c_Period_ID  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
