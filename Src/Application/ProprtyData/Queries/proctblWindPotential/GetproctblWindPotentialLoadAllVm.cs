using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblWindPotential
{
    public class GetproctblWindPotentialLoadAllVm : IMapFrom<tblWindPotential>
    {
        public long id { get; set; }
        public long? Resource_Id { get; set; }
        public long? Unit { get; set; }
        public string AAWS { get; set; }
        public string AAWD { get; set; }
        public string Measurement_Height { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblWindPotential, GetproctblWindPotentialLoadAllVm>();
        }
    }
}
