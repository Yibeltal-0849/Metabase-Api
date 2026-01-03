

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll;

namespace Application.Finance.Quiries.procCCustomer.GetCCustomerLoadByPrimaryKey
{ 
	 
	#region procCCustomerLoadByPrimaryKey  
    	
 public class GetprocCCustomerLoadByPrimaryKey : IRequest<GetprocCCustomerLoadAllListVM>
    {
    
		public string Customer_ID   { get; set; }
		
    }
   
        #endregion
		
	  
	
		
	
    
}

