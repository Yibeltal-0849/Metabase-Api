using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procLeaveApproval
{
    public class GetprocLeaveApprovalLoadAllVm : IMapFrom<LeaveApproval>
    {
        public System.Guid Leave_Tran_ID { get; set; }
        public System.Guid? Leave_ID { get; set; }
        public bool? IS_Approved { get; set; }
        public string Remark { get; set; }
        public System.Guid? Approved_By { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<LeaveApproval, GetprocLeaveApprovalLoadAllVm>();
        }
    }
}
