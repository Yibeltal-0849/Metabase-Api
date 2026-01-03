 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.proccVATPostingSetup.GetproccVATPostingSetupLoadAll;

namespace Application.Finance.Quiries.proccVATPostingSetup
{ 
	 
	#region proccVATPostingSetupLoadAll  
    
      public class GetproccVATPostingSetupLoadAllVM : IMapFrom<GetproccVATPostingSetupLoadAllListVM>
    {

        public string TAX_BusPosting_Group { get; set; }
        public string TAX_Prod_Psting_Group { get; set; }
        public string TAX_Per { get; set; }
        public string Sales_TAX_GL_Account { get; set; }
        public string Purchase_TAX_Account { get; set; }
        public string Reverse_Chrg_TAX_Account { get; set; }
        public bool? ISActive { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< CTaxPostingSetup, GetproccVATPostingSetupLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

