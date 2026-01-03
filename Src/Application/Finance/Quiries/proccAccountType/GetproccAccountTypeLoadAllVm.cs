using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccAccountType
{
    public class GetproccAccountTypeLoadAllVm : IMapFrom<CAccountType>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Catagory { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CAccountType, GetproccAccountTypeLoadAllVm>();
        }
    }
}
