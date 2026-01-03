using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.procTAXProdPostingGroup
{
    public class GetprocTAXProdPostingGroupLoadAllVm : IMapFrom<TAX_Prod_Posting_Group>
    {

        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TAX_Prod_Posting_Group, GetprocTAXProdPostingGroupLoadAllVm>();
        }
    }
}
