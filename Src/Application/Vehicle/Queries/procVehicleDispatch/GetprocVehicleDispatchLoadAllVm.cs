using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procVehicleDispatch
{
    public class GetprocVehicleDispatchLoadAllVm : IMapFrom<VehicleDispatch>
    {
        public System.Guid Vehicle_DispatchID { get; set; }
        public System.Guid? Vehicle_RequestID { get; set; }
        public System.Guid? Vehicle_OrderID { get; set; }
        public System.DateTime Dispatch_Date { get; set; }
        public string Status { get; set; }
        public System.Guid ActiveVehicle_ID { get; set; }
        public string Driver_Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<VehicleDispatch, GetprocVehicleDispatchLoadAllVm>();
        }
    }
}
