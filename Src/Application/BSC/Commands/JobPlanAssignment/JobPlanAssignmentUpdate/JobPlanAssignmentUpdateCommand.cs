using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.JobPlanAssignment.JobPlanAssignmentUpdate.JobPlanAssignmentUpdateCommand
{

	/// @author  Shimels Alem  Job_Plan_AssignmentUpdate stored procedure.

	public class JobPlanAssignmentUpdateCommand : IRequest<IList<JobPlanAssignment_JobPA_ID>>
   {
		public System.Guid JobPA_ID { get; set; }
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

