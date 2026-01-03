using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblElectricTransmissionDstribution
{
    public class GetproctblElectricTransmissionDstributionLoadAllVm : IMapFrom<tblElectricTransmissionDstribution>
    {
        public long id { get; set; }
        public long Region_id { get; set; }
        public System.DateTime Year { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblElectricTransmissionDstribution, GetproctblElectricTransmissionDstributionLoadAllVm>();
        }
    }
}
