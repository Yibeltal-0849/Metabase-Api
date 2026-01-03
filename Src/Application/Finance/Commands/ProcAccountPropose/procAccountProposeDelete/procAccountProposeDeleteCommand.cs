using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAccountProposeDelete.procAccountProposeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Account_ProposeDelete stored procedure.
	 
	#region proc_Account_ProposeDelete  
      
     
        public class procAccountProposeDeleteCommand : IRequest<IList<AccountPropose_Name>>
    {
    
		public string name  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
