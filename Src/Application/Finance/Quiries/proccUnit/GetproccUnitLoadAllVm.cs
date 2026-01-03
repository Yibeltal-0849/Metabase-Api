using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccUnit
{
    public class GetproccUnitLoadAllVm : IMapFrom<CUnit>
    {

        public string Unit { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CUnit, GetproccUnitLoadAllVm>();
        }
    }
}
