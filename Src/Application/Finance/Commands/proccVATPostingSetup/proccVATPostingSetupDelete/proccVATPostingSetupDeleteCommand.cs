using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccVATPostingSetupDelete.proccVATPostingSetupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_VAT_Posting_SetupDelete stored procedure.
	 
	#region proc_c_VAT_Posting_SetupDelete  
     
  /// proc_c_VAT_Posting_SetupDelete stored procedure.
     
        public class proccVATPostingSetupDeleteCommand : IRequest<IList<proccVATPostingSetup_vAT_BusPosting_Group>>
    {
    
		public string vAT_BusPosting_Group { get; set; }
		public string vAT_Prod_Psting_Group { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
