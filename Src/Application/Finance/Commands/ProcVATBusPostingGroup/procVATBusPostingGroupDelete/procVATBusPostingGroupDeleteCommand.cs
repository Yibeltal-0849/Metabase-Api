using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATBusPostingGroupDelete.procVATBusPostingGroupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Bus_Posting_GroupDelete stored procedure.
	 
	#region proc_VAT_Bus_Posting_GroupDelete  
     
  /// proc_VAT_Bus_Posting_GroupDelete stored procedure.
     
        public class procVATBusPostingGroupDeleteCommand : IRequest<IList<procVATBusPostingGroup_code>>
    {
    
		public string code { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
