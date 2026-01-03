using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccCustomerBalanceDelete.proccCustomerBalanceDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_Customer_BalanceDelete stored procedure.
	 
	#region proc_c_Customer_BalanceDelete  
     
  /// proc_c_Customer_BalanceDelete stored procedure.
     
        public class proccCustomerBalanceDeleteCommand : IRequest<IList<CCustomerBalance_Id>>
    {
    
		public long id  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
