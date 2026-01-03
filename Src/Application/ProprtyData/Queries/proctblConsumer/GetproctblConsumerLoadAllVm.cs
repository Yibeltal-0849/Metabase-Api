using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblConsumer
{
    public class GetproctblConsumerLoadAllVm : IMapFrom<tblConsumer>
    {
        public long? id { get; set; }
        public long? Chain_id { get; set; }
        public long? Energy_Id { get; set; }
        public long? Woreda_id { get; set; }
        public long? End_Use_id { get; set; }
        public long? Created_By { get; set; }
        public System.DateTime? Update_Date { get; set; }
        public long? Update_by { get; set; }
        public byte[] Last_Modified { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblConsumer, GetproctblConsumerLoadAllVm>();
        }
    }
}
