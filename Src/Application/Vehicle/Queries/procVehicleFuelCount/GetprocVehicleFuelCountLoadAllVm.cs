using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procVehicleFuelCount
{
    public class GetprocVehicleFuelCountLoadAllVm : IMapFrom<VehicleFuelCount>
    {
        public System.Guid Vehicle_CountID { get; set; }
        public System.Guid? Vehicle_DispatchID { get; set; }
        public double? Fill_Amount { get; set; }
        public double? Last_Amount { get; set; }
        public System.Guid? document_detail_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<VehicleFuelCount, GetprocVehicleFuelCountLoadAllVm>();
        }
    }
}
