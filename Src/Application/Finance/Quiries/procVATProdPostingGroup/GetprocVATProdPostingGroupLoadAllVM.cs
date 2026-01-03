 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.procVATProdPostingGroup.GetprocVATProdPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVATProdPostingGroup
{ 
	 
	#region procVATProdPostingGroupLoadAll  
    
      public class GetprocVATProdPostingGroupLoadAllVM : IMapFrom<GetprocVATProdPostingGroupLoadAllListVM>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Def_VAT_Prod_Posting_Group { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< GenProductPostingGroup, GetprocVATProdPostingGroupLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

