

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll;
using System;

namespace Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadByUserID
{ 
	 
	#region procCCustomerLoadByPrimaryKey  
    	
 public class GetprocCCustomerLoadByUserID : IRequest<GetprocCCustomerLoadAllListVM>
    {
    
		public Guid UserId { get; set; }
		
    }
   
        #endregion
		
	  
	
		
	
    
}

