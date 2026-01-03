using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.Store
{
    public class GetStoreLoadAllVm : IMapFrom<_Store>
    {
        public string Store_code { get; set; }
        public string Store_Name { get; set; }
        public System.Guid? Store_Type { get; set; }
        public System.Guid? Organization { get; set; }
        public System.Guid? DIV { get; set; }
        public string Location { get; set; }
        public string Log { get; set; }
        public bool? Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<_Store, GetStoreLoadAllVm>();
        }
    }
}
