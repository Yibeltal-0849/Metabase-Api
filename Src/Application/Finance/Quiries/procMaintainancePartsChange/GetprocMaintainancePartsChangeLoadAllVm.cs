using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procMaintainancePartsChange
{
    public class GetprocMaintainancePartsChangeLoadAllVm : IMapFrom<MaintainancePartsChange>
    {
        public long? PartsCange_ID { get; set; }
        public string Maintainance_ID { get; set; }
        public System.Double? Unit_Cost { get; set; }
        public System.Double? Quantity { get; set; }
        public System.Double? Total_Cost { get; set; }
        public string Transfer_Req_DetailID { get; set; }
        public string Item_ID { get; set; }
        public bool? IsChanged { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<MaintainancePartsChange, GetprocMaintainancePartsChangeLoadAllVm>();
        }
    }
}
