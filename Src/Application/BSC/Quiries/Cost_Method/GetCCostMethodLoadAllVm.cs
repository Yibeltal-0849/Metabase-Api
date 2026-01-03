using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.Cost_Method
{
    public class GetCCostMethodLoadAllVm : IMapFrom<Proc_C_Cost_Method>
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_C_Cost_Method, GetCCostMethodLoadAllVm>();
        }
    }
}
