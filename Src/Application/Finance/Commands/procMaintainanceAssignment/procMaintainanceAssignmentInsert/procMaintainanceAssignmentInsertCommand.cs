


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procMaintainanceAssignment.procMaintainanceAssignmentInsert.procMaintainanceAssignmentInsertCommand
{

	/// @author  Shimels Alem  proc_Maintainance_AssignmentInsert stored procedure.


	public class procMaintainanceAssignmentInsertCommand : IRequest<IList<MaintainanceAssignment_Ment_AssignmentID>>
	{
		public long? Ment_AssignmentID { get; set; }
		public string Maintainance_ID { get; set; }
		public string Assigned_To { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public string Status { get; set; }
	}
		
		
		 
}
 
 