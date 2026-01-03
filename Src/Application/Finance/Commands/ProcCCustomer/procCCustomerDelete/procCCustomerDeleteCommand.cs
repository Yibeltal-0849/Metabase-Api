using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCCustomerDelete.procCCustomerDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_C_CustomerDelete stored procedure.
	 
	#region proc_C_CustomerDelete  
     
  /// proc_C_CustomerDelete stored procedure.
     
        public class procCCustomerDeleteCommand : IRequest<IList<CCustomer_Customer_ID>>
    {
        public string customer_ID  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
