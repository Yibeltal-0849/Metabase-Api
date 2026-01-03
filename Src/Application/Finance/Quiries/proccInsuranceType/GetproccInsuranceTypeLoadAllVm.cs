using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccInsuranceType
{
    public class GetproccInsuranceTypeLoadAllVm : IMapFrom<CInsuranceType>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CInsuranceType, GetproccInsuranceTypeLoadAllVm>();
        }
    }
}
