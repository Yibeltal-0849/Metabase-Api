using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceProductions
{
    public class GetproctblResourceProductionsLoadAllVm : IMapFrom<tblResourceProductions>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Production_Period { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public string Resource_id { get; set; }
        public string ResourceVariable_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceProductions, GetproctblResourceProductionsLoadAllVm>();
        }
    }
}
