using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationTypeDelete.procorganizationTypeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_organization_TypeDelete stored procedure.
	 
	#region proc_organization_TypeDelete  
     
  /// proc_organization_TypeDelete stored procedure.
     
        public class procorganizationTypeDeleteCommand : IRequest<IList<procorganizationType_organization_Type_Code>>
    {
 
		public System.Guid organization_Type_Code  { get; set; } 
    }
		
        #endregion
		
		 
	}
 
 
