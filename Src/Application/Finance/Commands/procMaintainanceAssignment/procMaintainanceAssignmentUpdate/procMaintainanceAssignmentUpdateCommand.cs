using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procMaintainanceAssignment.procMaintainanceAssignmentUpdate.procMaintainanceAssignmentUpdateCommand
{

	/// @author  Shimels Alem  proc_Maintainance_AssignmentUpdate stored procedure.


	public class procMaintainanceAssignmentUpdateCommand : IRequest<IList<MaintainanceAssignment_Ment_AssignmentID>>
   {
		public long? Ment_AssignmentID { get; set; }
		public string Maintainance_ID { get; set; }
		public string Assigned_To { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public string Status { get; set; }
	}
		
		
		 
}

