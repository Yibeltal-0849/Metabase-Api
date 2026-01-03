using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdBusinessTypeUpdate.procAdBusinessTypeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Business_TypeUpdate stored procedure.
	 
	#region proc_Ad_Business_TypeUpdate  
     
  /// proc_Ad_Business_TypeUpdate stored procedure.
     
        public class procAdBusinessTypeUpdateCommand : IRequest<IList<AdBusinessType_Id>>
    {
    
		public long id { get; set; }
		public string name  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
