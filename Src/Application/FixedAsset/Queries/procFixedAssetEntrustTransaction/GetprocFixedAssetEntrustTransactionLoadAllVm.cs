using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction
{
    public class GetprocFixedAssetEntrustTransactionLoadAllVm : IMapFrom<FixedAssetEntrustTransaction>
    {
        public System.Guid Entrust_Trans_ID { get; set; }
        public string application_number { get; set; }
        public System.DateTime? Request_Date { get; set; }
        public System.Guid? services_service_code { get; set; }
        public string Service_Name { get; set; }
        public System.Guid? organization_code { get; set; }
        public System.Guid? Requested_By { get; set; }
        public System.Guid? DIV { get; set; }
        public string Address { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FixedAssetEntrustTransaction, GetprocFixedAssetEntrustTransactionLoadAllVm>();
        }
    }
}
