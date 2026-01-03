using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalDelete.proccGeneraljournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journalDelete stored procedure.
	 
	#region proc_c_General_journalDelete  
     
  /// proc_c_General_journalDelete stored procedure.
     
        public class proccGeneraljournalDeleteCommand : IRequest<IList<proccGeneraljournal_account_Id>>
    {
    
		public string account_Id  { get; set; }
		public long brnach_ID  { get; set; }
		public DateTime dateDoc  { get; set; }
		public long org_ID  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
