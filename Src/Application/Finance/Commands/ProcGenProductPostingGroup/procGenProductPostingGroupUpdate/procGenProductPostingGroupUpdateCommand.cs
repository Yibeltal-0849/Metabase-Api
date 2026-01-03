using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGenProductPostingGroupUpdate.procGenProductPostingGroupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Gen_Product_Posting_GroupUpdate stored procedure.
	 
	#region proc_Gen_Product_Posting_GroupUpdate  
     
  /// proc_Gen_Product_Posting_GroupUpdate stored procedure.
     
        public class procGenProductPostingGroupUpdateCommand : IRequest<IList<procGenProductPostingGroup_code>>
    {

		public string code { get; set; }
		public string description { get; set; }
		public string def_VAT_Prod_Posting_Group { get; set; }
	}
		
        #endregion
		
		 
	}
 
 
