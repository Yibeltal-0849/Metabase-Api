using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAccountProposeInsert.procAccountProposeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Account_ProposeInsert stored procedure.
	 
	#region proc_Account_ProposeInsert  
     
  /// proc_Account_ProposeInsert stored procedure.
     
        public class procAccountProposeInsertCommand : IRequest<IList<AccountPropose_Name>>
    {
    
		public string name  { get; set; }
		public bool? isActive  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
