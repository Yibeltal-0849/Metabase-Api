using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procActiveVehicle
{
    public class GetprocActiveVehicleLoadAllVm : IMapFrom<ActiveVehicle>
    {
        public System.Guid ActiveVehicle_ID { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Driver_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ActiveVehicle, GetprocActiveVehicleLoadAllVm>();
        }
    }
}
