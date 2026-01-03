using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procADOrgDelete.procADOrgDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_AD_OrgDelete stored procedure.
	 
	#region proc_AD_OrgDelete  
     
  /// proc_AD_OrgDelete stored procedure.
     
        public class procADOrgDeleteCommand : IRequest<IList<AdOrg_Code>>
    {
    
		public string code  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
