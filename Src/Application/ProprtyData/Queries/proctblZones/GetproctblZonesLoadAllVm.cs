using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblZones
{
    public class GetproctblZonesLoadAllVm : IMapFrom<tblZones>
    {
        public int id { get; set; }
        public string description { get; set; }
        public long? regions_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblZones, GetproctblZonesLoadAllVm>();
        }
    }
}
