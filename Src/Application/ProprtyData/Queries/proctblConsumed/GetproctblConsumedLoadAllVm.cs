using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblConsumed
{
    public class GetproctblConsumedLoadAllVm : IMapFrom<tblConsumed>
    {
        public long? id { get; set; }
        public long? Consumer_id { get; set; }
        public long? Energy_Id { get; set; }
        public long? Varable_id { get; set; }
        public string Year { get; set; }
        public long? Unit { get; set; }
        public decimal? Value { get; set; }
        public string Source { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblConsumed, GetproctblConsumedLoadAllVm>();
        }
    }
}
