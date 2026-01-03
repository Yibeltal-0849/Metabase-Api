 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.procAdAccountingMethod.GetprocAdAccountingMethodLoadAll;

namespace Application.Finance.Quiries.procAdAccountingMethod
{ 
	 
	#region procAdAccountingMethodLoadAll  
    
      public class GetprocAdAccountingMethodLoadAllVM : IMapFrom<GetprocAdAccountingMethodLoadAllListVM>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< AdAccountingMethod, GetprocAdAccountingMethodLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

