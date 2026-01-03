using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procVehicleRequst
{
    public class GetprocVehicleRequstLoadAllVm : IMapFrom<VehicleRequst>
    {
        public Guid Vehicle_RequestID { get; set; }
        public string Requested_By { get; set; }
        public DateTime? Request_Date { get; set; }
        public DateTime? RequsetFor_Date { get; set; }
        public Guid? Application_code { get; set; }
        public string Application_No { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<VehicleRequst, GetprocVehicleRequstLoadAllVm>();
        }
    }
}
