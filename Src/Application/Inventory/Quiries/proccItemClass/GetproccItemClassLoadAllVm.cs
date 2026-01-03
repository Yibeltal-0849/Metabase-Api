using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.proccItemClass
{
    public class GetproccItemClassLoadAllVm : IMapFrom<c_ItemClass>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<c_ItemClass, GetproccItemClassLoadAllVm>();
        }
    }
}
