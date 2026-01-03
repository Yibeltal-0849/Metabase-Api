using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceAmount
{
    public class GetproctblResourceAmountLoadAllVm : IMapFrom<tblResourceAmount>
    {
        public long Resource_id { get; set; }
        public long ResourceVariable_id { get; set; }
        public System.DateTime Report_Period { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public decimal Value { get; set; }
        public long Unit { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceAmount, GetproctblResourceAmountLoadAllVm>();
        }
    }
}
