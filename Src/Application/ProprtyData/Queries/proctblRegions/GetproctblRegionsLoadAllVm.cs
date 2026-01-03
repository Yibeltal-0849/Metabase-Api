using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblRegions
{
    public class GetproctblRegionsLoadAllVm : IMapFrom<tblRegions>
    {
        public long id { get; set; }
        public string description { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblRegions, GetproctblRegionsLoadAllVm>();
        }
    }
}
