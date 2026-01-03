using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCTax
{
    public class GetprocCTaxLoadAllVm : IMapFrom<CTax>
    {

        public string Org_ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Enable { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CTax, GetprocCTaxLoadAllVm>();
        }
    }
}
