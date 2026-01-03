 

using AutoMapper; 
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using Application.Finance.Quiries.proccTAXPostingSetup.GetproccTAXPostingSetupLoadAll;

namespace Application.Finance.Quiries.proccTAXPostingSetup
{ 
	 
	#region proccTAXPostingSetupLoadAll  
    
      public class GetproccTAXPostingSetupLoadAllVM : IMapFrom<GetproccTAXPostingSetupLoadAllListVM>
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
            profile.CreateMap< CTaxPostingSetup, GetproccTAXPostingSetupLoadAllVM>();
        }
    }
    #endregion
		
	  
	
		
	
    
}

