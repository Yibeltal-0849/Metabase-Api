

using MediatR;
using System; 
using Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadAll;

namespace Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadByPrimaryKey
{ 
	 
	#region ProcAdYearLoadByPrimaryKey  
    	
 public class GetProcAdYearLoadByPrimaryKey : IRequest<GetProcAdYearLoadAllListVM>
    {
    
		public string Year { get; set; }
		
    }
   
        #endregion
		
	  
	
		
	
    
}

