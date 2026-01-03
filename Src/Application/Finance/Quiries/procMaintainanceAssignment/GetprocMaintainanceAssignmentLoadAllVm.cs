using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procMaintainanceAssignment
{
    public class GetprocMaintainanceAssignmentLoadAllVm : IMapFrom<MaintainanceAssignment>
    {
        public long? Ment_AssignmentID { get; set; }
        public string Maintainance_ID { get; set; }
        public string Assigned_To { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public string Status { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<MaintainanceAssignment, GetprocMaintainanceAssignmentLoadAllVm>();
        }
    }
}
