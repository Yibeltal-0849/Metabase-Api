using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.InventoryItems
{
    public class GetInventoryItempriceVm : IMapFrom<Inventory_Items>
    {
        public decimal? Price { get; set; }
       
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Inventory_Items, GetInventoryItempriceVm>();
        }
    }
}
