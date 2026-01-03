using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procInventoryPostingSetupDelete.procInventoryPostingSetupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Inventory_Posting_SetupDelete stored procedure.
	 
	#region proc_Inventory_Posting_SetupDelete  
     
  /// proc_Inventory_Posting_SetupDelete stored procedure.
     
        public class procInventoryPostingSetupDeleteCommand : IRequest<IList<procInventoryPostingSetup_store_Code>>
    {
    
		public string store_Code { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
