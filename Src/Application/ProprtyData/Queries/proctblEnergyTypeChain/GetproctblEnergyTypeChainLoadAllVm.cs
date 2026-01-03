using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblEnergyTypeChain
{
    public class GetproctblEnergyTypeChainLoadAllVm : IMapFrom<tblEnergyTypeChain>
    {
        public long id { get; set; }
        public long? Energy_Type_id { get; set; }
        public long? Energy_Chain_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblEnergyTypeChain, GetproctblEnergyTypeChainLoadAllVm>();
        }
    }
}
