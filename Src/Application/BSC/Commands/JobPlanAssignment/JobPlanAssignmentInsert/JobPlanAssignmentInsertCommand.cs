


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.JobPlanAssignment.JobPlanAssignmentInsert.JobPlanAssignmentInsertCommand
{

	/// @author  Shimels Alem  Job_Plan_AssignmentInsert stored procedure.


	public class JobPlanAssignmentInsertCommand : IRequest<IList<JobPlanAssignment_JobPA_ID>>
    {
		public System.Guid? JobPA_ID { get; set; }
		public string Operational_Task_ID { get; set; }
		public System.Guid? Assigned_Body { get; set; }
		public System.Guid? Responsible_Role { get; set; }
		public string Responsible_User_ID { get; set; }
		public bool? Is_Active { get; set; }
		public Byte[] Log { get; set; }
		public string ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string Doc_No { get; set; }
		public System.Guid? Assigned_By { get; set; }
	}
		
		
		 
	}
 
 