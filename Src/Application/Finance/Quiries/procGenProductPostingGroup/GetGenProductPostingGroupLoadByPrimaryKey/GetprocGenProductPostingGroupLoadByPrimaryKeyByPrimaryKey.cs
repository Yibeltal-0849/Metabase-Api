

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.procGenProductPostingGroup.GetprocGenProductPostingGroupLoadAll;

namespace Application.Finance.Quiries.procGenProductPostingGroup.GetGenProductPostingGroupLoadByPrimaryKey
{ 
	 
	#region procGenProductPostingGroupLoadByPrimaryKey  
    	
 public class GetprocGenProductPostingGroupLoadByPrimaryKey  : IRequest<GetprocGenProductPostingGroupLoadAllListVM>
    {
    
		public string Code   { get; set; }
		
    }
   
        #endregion
		
	  
	
		
	
    
}

