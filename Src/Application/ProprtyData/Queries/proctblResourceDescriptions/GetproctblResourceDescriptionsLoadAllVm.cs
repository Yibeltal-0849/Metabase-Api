using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceDescriptions
{
    public class GetproctblResourceDescriptionsLoadAllVm : IMapFrom<tblResourceDescriptions>
    {
        public long id { get; set; }
        public long? Resource_id { get; set; }
        public long? ResourceVariable_id { get; set; }
        public string Value { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceDescriptions, GetproctblResourceDescriptionsLoadAllVm>();
        }
    }
}
