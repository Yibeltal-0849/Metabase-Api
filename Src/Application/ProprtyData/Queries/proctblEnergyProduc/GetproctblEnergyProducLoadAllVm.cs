using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblEnergyProduc
{
    public class GetproctblEnergyProducLoadAllVm : IMapFrom<tblEnergyProduc>
    {
        public long Id { get; set; }
        public string Energy_Number { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblEnergyProduc, GetproctblEnergyProducLoadAllVm>();
        }
    }
}
