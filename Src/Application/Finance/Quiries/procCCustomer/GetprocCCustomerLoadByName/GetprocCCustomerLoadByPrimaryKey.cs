

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll;

namespace Application.Finance.Quiries.procCCustomer.GetCCustomerLoadByPrimaryKey
{ 
	 
	#region procCCustomerLoadByPrimaryKey  
    	
 public class GetprocCCustomerLoadByName : IRequest<GetprocCCustomerLoadAllListVM>
    {

		public string Name { get; set; }

	}
   
        #endregion
		
	  
	
		
	
    
}

