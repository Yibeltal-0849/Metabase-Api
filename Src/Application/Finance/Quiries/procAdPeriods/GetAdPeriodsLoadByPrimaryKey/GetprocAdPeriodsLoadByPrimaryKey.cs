

using MediatR;
using System; 
using Application.Finance.Quiries.procAdPeriods.GetprocAdPeriodsLoadAll;

namespace Application.Finance.Quiries.procAdPeriods.GetAdPeriodsLoadByPrimaryKey
{ 
	 
	#region procAdPeriodsLoadByPrimaryKey  
    	
 public class GetprocAdPeriodsLoadByPrimaryKey : IRequest<GetprocAdPeriodsLoadAllListVM>
    {
    
		public DateTime StartDate   { get; set; }
		
    }
   
        #endregion
		
	  
	
		
	
    
}

