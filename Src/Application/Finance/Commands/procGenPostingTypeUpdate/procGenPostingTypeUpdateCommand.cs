using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGenPostingTypeUpdate.procGenPostingTypeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Gen_Posting_TypeUpdate stored procedure.
	 
	#region proc_Gen_Posting_TypeUpdate  
     
  /// proc_Gen_Posting_TypeUpdate stored procedure.
     
        public class procGenPostingTypeUpdateCommand : IRequest<IList<procGenPostingType_code>>
    {
    
		public string code { get; set; }
		public bool? is_Active { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
