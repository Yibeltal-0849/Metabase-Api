using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment
{
    public class GetAnnualStrategicPlanAssignmentLoadAllVm : IMapFrom<Proc_Annual_Strategic_Plan_Assignment>
    {
		public System.Guid? ASPA_ID { get; set; }
		public string ASGD_ID { get; set; }
		public System.Guid? Assigned_Body { get; set; }
		public System.Guid? Responsible_Role { get; set; }
		public bool? Is_Active { get; set; }
		public Byte[] Log { get; set; }
		public string ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string Doc_No { get; set; }
		public System.Guid? Assigned_By { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_Annual_Strategic_Plan_Assignment, GetAnnualStrategicPlanAssignmentLoadAllVm>();
        }
    }
}
