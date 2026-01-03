

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll;

namespace Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadByMobile
{

    #region GetprocCCustomerLoadByMobile  

    public class GetprocCCustomerLoadByMobile : IRequest<GetprocCCustomerLoadAllListVM>
    {
    
		public string Mobile { get; set; }
		
    }
   
        #endregion
		
	  
	
		
	
    
}

