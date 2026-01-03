 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.procAdBusinessType.GetprocAdBusinessTypeLoadAll;

namespace Application.Finance.Quiries.procAdBusinessType
{ 
	 
	#region procAdBusinessTypeLoadAll  
    
      public class GetprocAdBusinessTypeLoadAllVM : IMapFrom<GetprocAdBusinessTypeLoadAllListVM>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< AdBusinessType, GetprocAdBusinessTypeLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

