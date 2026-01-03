using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procFixedAssetMent
{
    public class GetprocFixedAssetMentLoadAllVm : IMapFrom<FixedAssetMent>
    {
        public string Maintainance_ID { get; set; }
        public string Remark { get; set; }
        public Guid? FixedAsset_Maintan_Trans_ID { get; set; }
        public DateTime? Mainanace_Request_Date { get; set; }
        public string FIXED_Asset_No { get; set; }
        public string Unit { get; set; }
        public Double? Quantity { get; set; }
        public string Vocher_NO { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FixedAssetMent, GetprocFixedAssetMentLoadAllVm>();
        }
    }
}
