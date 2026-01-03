using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATProdPostingGroupDelete.procVATProdPostingGroupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Prod_Posting_GroupDelete stored procedure.
	 
	#region proc_VAT_Prod_Posting_GroupDelete  
     
  /// proc_VAT_Prod_Posting_GroupDelete stored procedure.
     
        public class procVATProdPostingGroupDeleteCommand : IRequest<IList<procVATProdPostingGroup_code>>
    {
    
		public string _code  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
