using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procVehicleLeaseTo
{
    public class GetprocVehicleLeaseToLoadAllVm : IMapFrom<VehicleLeaseTo>
    {
        public System.Guid Vehicle_LeaseToID { get; set; }
        public System.Guid? Customer_ID { get; set; }
        public double? Millage { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Remark { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<VehicleLeaseTo, GetprocVehicleLeaseToLoadAllVm>();
        }
    }
}
