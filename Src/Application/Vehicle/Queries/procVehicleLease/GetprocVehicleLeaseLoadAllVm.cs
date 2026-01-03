using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procVehicleLease
{
    public class GetprocVehicleLeaseLoadAllVm : IMapFrom<VehicleLease>
    {
        public System.Guid Vehicle_LeaseID { get; set; }
        public string Vendor_ID { get; set; }
        public double? Millage { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Remark { get; set; }
        public string Application_Number { get; set; }
        public Guid? Application_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<VehicleLease, GetprocVehicleLeaseLoadAllVm>();
        }
    }
}
