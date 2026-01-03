using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.InnitiativePlanAssignment.UpdateInnitiativePlanAssignment
{
	/// @author  Shimels Alem  Innitiative_Plan_AssignmentUpdate stored procedure.

	public class UpdateInnitiativePlanAssignmentCommand : IRequest<IList<Innitiative_Plan_Assignment_IPA_ID>>
    {
		public Guid IPA_ID { get; set; }
		public string Innitiative_ID { get; set; }
		public Guid? Assigned_Body { get; set; }
		public Guid? Responsible_Role { get; set; }
		public bool? Is_Active { get; set; }
		public Byte[] Log { get; set; }
		public Guid? ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string Doc_No { get; set; }
		public Guid? Assigned_By { get; set; }
		public bool? Is_Owner { get; set; }
	}
}
