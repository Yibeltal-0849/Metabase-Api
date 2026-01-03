using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATProdPostingGroupInsert.procVATProdPostingGroupInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Prod_Posting_GroupInsert stored procedure.
	 
	#region proc_VAT_Prod_Posting_GroupInsert  
     
  /// proc_VAT_Prod_Posting_GroupInsert stored procedure.
     
        public class procVATProdPostingGroupInsertCommand : IRequest<IList<procVATProdPostingGroup_code>>
    {
    
		public string _code  { get; set; }
		public string _description  { get; set; }
		public bool? _active  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
