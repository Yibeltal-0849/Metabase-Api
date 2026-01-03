 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.procGenProductPostingGroup.GetprocGenProductPostingGroupLoadAll;

namespace Application.Finance.Quiries.procGenProductPostingGroup.GetprocGenProductPostingGroupLoadAll
{ 
	 
	#region procGenProductPostingGroupLoadAll  
    
      public class GetprocGenProductPostingGroupLoadAllVM : IMapFrom<GetprocGenProductPostingGroupLoadAllListVM>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Def_VAT_Prod_Posting_Group { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap< GenProductPostingGroup, GetprocGenProductPostingGroupLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

