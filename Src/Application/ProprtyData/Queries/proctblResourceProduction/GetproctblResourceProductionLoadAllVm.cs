using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceProduction
{
    public class GetproctblResourceProductionLoadAllVm : IMapFrom<tblResourceProduction>
    {
        public long Facility_id { get; set; }
        public long Variable_id { get; set; }
        public System.DateTime Production_Period { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public long Unit { get; set; }
        public long Value { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceProduction, GetproctblResourceProductionLoadAllVm>();
        }
    }
}
