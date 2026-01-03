using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.procTAXBusPostingGroup
{
    
    public class GetprocTAXBusPostingGroupLoadAllVm : IMapFrom<TAX_Bus_Posting_Group>
    {

        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TAX_Bus_Posting_Group, GetprocTAXBusPostingGroupLoadAllVm>();
        }
    }
}
