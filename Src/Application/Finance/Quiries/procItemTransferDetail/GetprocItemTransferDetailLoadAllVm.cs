using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procItemTransferDetail
{
    public class GetprocItemTransferDetailLoadAllVm : IMapFrom<ItemTransferDetail>
    {
        public string Transfer_Req_DetailID { get; set; }
        public string Vocher_NO { get; set; }
        public string Json_Data { get; set; }
        public string Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemTransferDetail, GetprocItemTransferDetailLoadAllVm>();
        }
    }
}
