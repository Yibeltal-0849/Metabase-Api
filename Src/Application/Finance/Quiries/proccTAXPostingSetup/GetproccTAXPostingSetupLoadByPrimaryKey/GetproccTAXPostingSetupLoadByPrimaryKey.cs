

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.proccTAXPostingSetup.GetproccTAXPostingSetupLoadAll;

namespace Application.Finance.Quiries.proccTAXPostingSetup.GetTAXPostingSetupLoadByPrimaryKey
{ 
	 
	#region proccTAXPostingSetupLoadByPrimaryKey  
    	
 public class GetproccTAXPostingSetupLoadByPrimaryKey  : IRequest<GetproccTAXPostingSetupLoadAllListVM>
    {
    	public string tAX_BusPosting_Group { get; set; }
		public string tAX_Prod_Psting_Group { get; set; }
		public string Gen_TAX_Posting_Group { get; set; }
		public string TAX_Type { get; set; }
		public string tAX_Per { get; set; }
		public string sales_TAX_GL_Account { get; set; }
		public string purchase_TAX_Account { get; set; }
		public string reverse_Chrg_TAX_Account { get; set; }

	}
   
        #endregion
		
	  
	
		
	
    
}

