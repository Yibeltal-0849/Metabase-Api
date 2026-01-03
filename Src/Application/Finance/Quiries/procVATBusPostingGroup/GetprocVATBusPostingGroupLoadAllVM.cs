 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.procVATBusPostingGroup.GetprocVATBusPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVATBusPostingGroup
{ 
	 
	#region procVATBusPostingGroupLoadAll  
    
      public class GetprocVATBusPostingGroupLoadAllVM : IMapFrom<GetprocVATBusPostingGroupLoadAllListVM>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Def_VATBusPostingGroup { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< GenBusPostingGroups, GetprocVATBusPostingGroupLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

