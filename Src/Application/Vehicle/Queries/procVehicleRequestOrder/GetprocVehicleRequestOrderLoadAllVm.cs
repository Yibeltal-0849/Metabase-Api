using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Queries.procVehicleRequestOrder
{
    public class GetprocVehicleRequestOrderLoadAllVm : IMapFrom<VehicleRequestOrder>
    {
        public System.Guid Vehicle_OrderID { get; set; }
        public System.Guid? Vehicle_RequestID { get; set; }
        public System.Guid? Employee_ID { get; set; }
        public System.DateTime? Order_Date { get; set; }
        public string PickUp_Location { get; set; }
        public bool? Is_Approved { get; set; }
        public string Destination { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<VehicleRequestOrder, GetprocVehicleRequestOrderLoadAllVm>();
        }
    }
}
