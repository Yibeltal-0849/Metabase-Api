using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procOTRecord
{
    public class GetprocOTRecordLoadAllVm : IMapFrom<OtRecord>
    {
        public System.Guid OT_ID { get; set; }
        public System.Guid? Att_OT_Trans_Id { get; set; }
        public System.DateTime? Start_Date_Time { get; set; }
        public System.DateTime? End_Date_Time { get; set; }
        public string Reason { get; set; }
        public string Managment_Reason { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<OtRecord, GetprocOTRecordLoadAllVm>();
        }
    }
}
