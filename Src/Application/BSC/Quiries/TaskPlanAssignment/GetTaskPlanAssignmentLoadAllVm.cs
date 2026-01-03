using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.TaskPlanAssignment
{
    public class GetTaskPlanAssignmentLoadAllVm : IMapFrom<Task_Plan_Assignment>
    {
		public Guid stringTPA_ID { get; set; }
		public string Operational_Task_ID { get; set; }
		public Guid? Assigned_Body { get; set; }
		public Guid? Responsible_Role { get; set; }
		public string Responsible_User_ID { get; set; }
		public bool? Is_Active { get; set; }
		public Byte[] Log { get; set; }
		public string ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string Doc_No { get; set; }
		public Guid? Assigned_By { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Task_Plan_Assignment, GetTaskPlanAssignmentLoadAllVm>();
        }
    }
}
