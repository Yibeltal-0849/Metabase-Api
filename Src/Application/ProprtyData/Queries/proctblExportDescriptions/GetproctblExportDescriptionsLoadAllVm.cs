using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblExportDescriptions
{
    public class GetproctblExportDescriptionsLoadAllVm : IMapFrom<tblExportDescriptions>
    {
        public long id { get; set; }
        public long? Export_Id { get; set; }
        public long? Variable_id { get; set; }
        public string Value { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblExportDescriptions, GetproctblExportDescriptionsLoadAllVm>();
        }
    }
}
