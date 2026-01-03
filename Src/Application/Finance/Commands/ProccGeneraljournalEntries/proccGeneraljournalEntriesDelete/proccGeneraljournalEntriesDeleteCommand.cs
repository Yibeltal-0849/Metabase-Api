using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalEntriesDelete.proccGeneraljournalEntriesDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journal_Entries Delete stored procedure.
	 
	#region proc_c_General_journal_Entries Delete  
     
  /// proc_c_General_journal_Entries Delete stored procedure.
     
        public class proccGeneraljournalEntriesDeleteCommand : IRequest<IList<proccGeneraljournalEntries_org_ID>>
    {
    
		public System.Guid org_ID  { get; set; }
		public System.Guid brnach_ID  { get; set; }
		public DateTime  dateDoc  { get; set; }
		public string  journal_Type  { get; set; }
		public string  document_No  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
