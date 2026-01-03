using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStoreItemActivityTypeDelete.procStoreItemActivityTypeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Store_Item_Activity_TypeDelete stored procedure.
	 
	#region proc_Store_Item_Activity_TypeDelete  
     
  /// proc_Store_Item_Activity_TypeDelete stored procedure.
     
        public class procStoreItemActivityTypeDeleteCommand : IRequest<IList<Store_Item_Activity_Type_Code>>
    {
 
		public string code  { get; set; } 
    }
		
        #endregion
		
		 
	}
 
 
