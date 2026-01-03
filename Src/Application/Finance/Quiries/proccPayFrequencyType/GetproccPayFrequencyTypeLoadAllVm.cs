using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccPayFrequencyType
{
    public class GetproccPayFrequencyTypeLoadAllVm : IMapFrom<CPayFrequencyType>
    {

        public string Name { get; set; }
        public bool? Enable { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CPayFrequencyType, GetproccPayFrequencyTypeLoadAllVm>();
        }
    }
}
