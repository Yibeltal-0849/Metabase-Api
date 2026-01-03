using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAccountProposeUpdate.procAccountProposeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Account_ProposeUpdate stored procedure.
	 
	#region proc_Account_ProposeUpdate  
     
  /// proc_Account_ProposeUpdate stored procedure.
     
        public class procAccountProposeUpdateCommand : IRequest<IList<AccountPropose_Name>>
    {
		public string name { get; set; }
		public bool? isActive { get; set; }
	}
		
        #endregion
		
		 
	}
 
 
