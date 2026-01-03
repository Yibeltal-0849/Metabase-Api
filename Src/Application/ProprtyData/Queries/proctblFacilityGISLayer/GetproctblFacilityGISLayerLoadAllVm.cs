using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblFacilityGISLayer
{
    public class GetproctblFacilityGISLayerLoadAllVm : IMapFrom<tblFacilityGISLayer>
    {
        public long Facility_id { get; set; }
        public long FID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblFacilityGISLayer, GetproctblFacilityGISLayerLoadAllVm>();
        }
    }
}
