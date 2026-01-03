using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdBusinessTypeDelete.procAdBusinessTypeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Business_TypeDelete stored procedure.
	 
	#region proc_Ad_Business_TypeDelete  
     
  /// proc_Ad_Business_TypeDelete stored procedure.
     
        public class procAdBusinessTypeDeleteCommand : IRequest<IList<AdBusinessType_Id>>
    {
    
		public long id  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
