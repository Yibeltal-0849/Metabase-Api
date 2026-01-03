using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATBusPostingGroupUpdate.procVATBusPostingGroupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Bus_Posting_GroupUpdate stored procedure.
	 
	#region proc_VAT_Bus_Posting_GroupUpdate  
     
  /// proc_VAT_Bus_Posting_GroupUpdate stored procedure.
     
        public class procVATBusPostingGroupUpdateCommand : IRequest<IList<procVATBusPostingGroup_code>>
    {
    
		public string code { get; set; }
		public string description { get; set; }
		public bool? active { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
