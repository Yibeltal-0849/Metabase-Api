using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATProdPostingGroupUpdate.procVATProdPostingGroupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Prod_Posting_GroupUpdate stored procedure.
	 
	#region proc_VAT_Prod_Posting_GroupUpdate  
     
  /// proc_VAT_Prod_Posting_GroupUpdate stored procedure.
     
        public class procVATProdPostingGroupUpdateCommand : IRequest
    {
    
		public string _code  { get; set; }
		public string _description  { get; set; }
		public bool? _active  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 