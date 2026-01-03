using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceGISLayer
{
    public class GetproctblResourceGISLayerLoadAllVm : IMapFrom<tblResourceGISLayer>
    {
        public long Resource_id { get; set; }
        public long FID { get; set; }
        public long? LayerId { get; set; }
        public long? Chain { get; set; }
        public long? Energy { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceGISLayer, GetproctblResourceGISLayerLoadAllVm>();
        }
    }
}
