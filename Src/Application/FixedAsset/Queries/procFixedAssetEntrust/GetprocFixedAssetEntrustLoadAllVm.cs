using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrust
{
    public class GetprocFixedAssetEntrustLoadAllVm : IMapFrom<FixedAssetEntrust>
    {
        public System.Guid Entrust_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
        public System.Guid? Entrust_Trans_ID { get; set; }
        public string Address { get; set; }
        public bool? Is_Active { get; set; }
        public System.Guid? Pervious_Enterus { get; set; }
        public string Record_No { get; set; }
        public string Remark { get; set; }
        public string Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FixedAssetEntrust, GetprocFixedAssetEntrustLoadAllVm>();
        }
    }
}
