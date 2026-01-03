using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procFleetContract
{
    public class GetprocFleetContractLoadAllVm : IMapFrom<FleetContract>
    {
        public string Contract_ID { get; set; }
        public System.Guid? Customer_ID { get; set; }
        public string Contract_Title { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? Vendor_ID { get; set; }
        public System.Double? Contract_Amount { get; set; }
        public string Fleet_Contract_Type { get; set; }
        public string Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FleetContract, GetprocFleetContractLoadAllVm>();
        }
    }
}
