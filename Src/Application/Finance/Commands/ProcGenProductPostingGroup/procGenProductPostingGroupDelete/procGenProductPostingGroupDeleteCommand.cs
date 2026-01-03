using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGenProductPostingGroupDelete.procGenProductPostingGroupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Gen_Product_Posting_GroupDelete stored procedure.
	 
	#region proc_Gen_Product_Posting_GroupDelete  
     
  /// proc_Gen_Product_Posting_GroupDelete stored procedure.
     
        public class procGenProductPostingGroupDeleteCommand : IRequest<IList<procGenProductPostingGroup_code>>
    {
    
		public string code { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
