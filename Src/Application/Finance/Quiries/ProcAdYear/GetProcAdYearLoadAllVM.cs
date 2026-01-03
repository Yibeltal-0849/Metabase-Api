 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using System;
using Application.Common.Mappings;
using Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadAll;

namespace Application.Finance.Quiries.ProcAdYear
{ 
	 
	#region ProcAdYearLoadAll  
    
      public class GetProcAdYearLoadAllVM : IMapFrom<GetProcAdYearLoadAllListVM>
    {
        public string Year { get; set; }
        public string Org { get; set; }
        public string Calander { get; set; }
        public bool? IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AdYear, GetProcAdYearLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

