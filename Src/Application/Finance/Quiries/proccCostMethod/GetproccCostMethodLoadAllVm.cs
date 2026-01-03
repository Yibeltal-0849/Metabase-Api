using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccCostMethod
{
    public class GetproccCostMethodLoadAllVm : IMapFrom<CCostMethod>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CCostMethod, GetproccCostMethodLoadAllVm>();
        }
    }
}
