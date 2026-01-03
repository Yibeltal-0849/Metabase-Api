using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procFleetContract
{
    public class GetprocFleetContractLoadAllVm : IMapFrom<FleetContract>
    {
        public string Contract_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Contract_Title { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public string Vendor_ID { get; set; }
        public double? Contract_Amount { get; set; }
        public string Fleet_Contract_Type { get; set; }
        public string Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FleetContract, GetprocFleetContractLoadAllVm>();
        }
    }
}
