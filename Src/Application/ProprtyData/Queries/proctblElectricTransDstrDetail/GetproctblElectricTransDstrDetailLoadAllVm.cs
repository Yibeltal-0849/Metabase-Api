using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblElectricTransDstrDetail
{
    public class GetproctblElectricTransDstrDetailLoadAllVm : IMapFrom<tblElectricTransDstrDetail>
    {
        public long id { get; set; }
        public long? ETD_ID { get; set; }
        public string Number_of_Substation_by_voltage_level { get; set; }
        public string Transmissions_line_length_in_km_by_voltage_level { get; set; }
        public string Distribution_line_length_by_voltage_level { get; set; }
        public string No_of_distribution_transformers { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblElectricTransDstrDetail, GetproctblElectricTransDstrDetailLoadAllVm>();
        }
    }
}
