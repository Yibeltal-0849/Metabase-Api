 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using System;
using Application.Common.Mappings;
using Application.Finance.Quiries.procAdPeriods.GetprocAdPeriodsLoadAll;

namespace Application.Finance.Quiries.procAdPeriods
{ 
	 
	#region procAdPeriodsLoadAll  
    
      public class GetprocAdPeriodsLoadAllVM : IMapFrom<GetprocAdPeriodsLoadAllListVM>
    {
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string Org_Id { get; set; }
        public string Name { get; set; }
        public bool? Date_Locked { get; set; }
        public bool? New_Fiscal_Year { get; set; }
        public bool? Closed { get; set; }
        public string Year { get; set; }
        public bool? Inventory_Period_Closed { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AdPeriods, GetprocAdPeriodsLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

