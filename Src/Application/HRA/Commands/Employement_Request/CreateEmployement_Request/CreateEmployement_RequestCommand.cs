using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Employement_Request.CreateEmployement_Request
{
    /// @author  Shimels Alem  CreateCEmployement_Request stored procedure.
    
    public class CreateEmployement_RequestCommand : IRequest<IList<EmployementRequest_JOBPost_ID>>
    {
		public Guid JOBPost_ID { get; set; }
		public Guid? application_code { get; set; }
		public Guid? Service_Code { get; set; }
		public string Service_Name { get; set; }
		public string Application_No { get; set; }
		public string Ref_NO { get; set; }
		public Guid? organization_code { get; set; }
		public Guid? Structure_ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public string Main_Innitiative_ID { get; set; }
		public DateTime? Application_StartDate { get; set; }
		public DateTime? Application_EndDate { get; set; }
		public bool? Is_Active { get; set; }
		public bool? internal_only { get; set; }

	}
}
