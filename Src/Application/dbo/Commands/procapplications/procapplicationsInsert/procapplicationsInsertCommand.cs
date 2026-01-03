


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procapplications.procapplicationsInsert.procapplicationsInsertCommand
{

	/// @author  Shimels Alem  proc_applicationsInsert stored procedure.


	public class procapplicationsInsertCommand : IRequest<IList<applications_applicationcode>>
    {
		public System.Guid application_code { get; set; }
		public string application_number { get; set; }
		public int? is_completed { get; set; }
		public string status { get; set; }
		public int? rollback_count { get; set; }
		public System.DateTime? date_created { get; set; }
		public string date_created_et { get; set; }
		public System.Guid? UserId { get; set; }
		public System.Guid? services_service_code { get; set; }
		public bool? is_synched { get; set; }
		public System.DateTime? date_synched { get; set; }
		public System.Guid? organization_code { get; set; }
		public long? QueueNo { get; set; }
	}
		
		
		 
}
 
 