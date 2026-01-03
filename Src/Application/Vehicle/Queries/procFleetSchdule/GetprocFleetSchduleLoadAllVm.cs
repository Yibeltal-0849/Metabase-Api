using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procFleetSchdule
{
    public class GetprocFleetSchduleLoadAllVm : IMapFrom<FleetSchdule>
    {
        public System.Guid Fleet_SchduleID { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Vendor_ID { get; set; }
        public string Title { get; set; }
        public System.DateTime? Registration_Date { get; set; }
        public System.Guid? Fleet_Schdule_Type { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FleetSchdule, GetprocFleetSchduleLoadAllVm>();
        }
    }
}
