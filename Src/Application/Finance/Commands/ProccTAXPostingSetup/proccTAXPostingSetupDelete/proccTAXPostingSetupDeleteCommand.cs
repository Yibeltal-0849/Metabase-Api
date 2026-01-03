using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccTAXPostingSetupDelete.proccTAXPostingSetupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_TAX_Posting_SetupDelete stored procedure.
	 
	#region proc_c_TAX_Posting_SetupDelete  
     
  /// proc_c_TAX_Posting_SetupDelete stored procedure.
     
        public class proccTAXPostingSetupDeleteCommand : IRequest<IList<proccTAXPostingSetup_TAX_BusPosting_Group>>
    {
    
		public string TAX_BusPosting_Group { get; set; }
		public string tAX_Prod_Psting_Group { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
