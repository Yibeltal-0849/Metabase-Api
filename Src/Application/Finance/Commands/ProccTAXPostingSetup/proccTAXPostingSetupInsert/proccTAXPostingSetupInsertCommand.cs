using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccTAXPostingSetupInsert.proccTAXPostingSetupInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_TAX_Posting_SetupInsert stored procedure.
	 
	#region proc_c_TAX_Posting_SetupInsert  
     
  /// proc_c_TAX_Posting_SetupInsert stored procedure.
     
        public class proccTAXPostingSetupInsertCommand : IRequest<IList<proccTAXPostingSetup_TAX_BusPosting_Group>>
    {
    
		public string  tAX_BusPosting_Group { get; set; }
		public string  tAX_Prod_Psting_Group { get; set; }
		public string  tAX_Per { get; set; }
		public string  sales_TAX_GL_Account { get; set; }
		public string  purchase_TAX_Account { get; set; }
		public string  reverse_Chrg_TAX_Account { get; set; }
		public bool?  iSActive { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
