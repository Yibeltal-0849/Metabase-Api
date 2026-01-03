using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.procInventoryPostingGroup
{
    public class GetprocInventoryPostingGroupLoadAllVm : IMapFrom<InventoryPostingGroup>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<InventoryPostingGroup, GetprocInventoryPostingGroupLoadAllVm>();
        }
    }
}
