 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;

namespace Application.Finance.Quiries.procAccountPropose
{ 
	 
	#region procAccountProposeLoadAll  
    
      public class GetprocAccountProposeLoadAllVM : IMapFrom<AccountPropose>
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< AccountPropose, GetprocAccountProposeLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

