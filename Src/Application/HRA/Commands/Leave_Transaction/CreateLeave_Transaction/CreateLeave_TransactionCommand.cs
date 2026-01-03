using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Leave_Transaction.CreateLeave_Transaction
{
    /// @author  Shimels Alem  proc_Leave_TransactionInsert stored procedure.

    public class CreateLeaveTypeLookup : IRequest<IList<LeaveApproval_Leave_Tran_ID>>
    {
		public Guid Leave_Tran_ID { get; set; }
		public Guid? Application_Code { get; set; }
		public string Application_NO { get; set; }
		public Guid? Service_Code { get; set; }
		public string Service_Name { get; set; }
		public string Employee_ID { get; set; }
		public bool? With_Salary { get; set; }
		public bool? With_Out_Salary { get; set; }
		public Guid? Leave_Type { get; set; }
		public DateTime? Leave_From_Start_Date { get; set; }
		public DateTime? Leave_End_Date { get; set; }
		public string? Leave_Resaon { get; set; }
		public Double? Total_Requested_Number { get; set; }
		public Guid? Document_Details_ID { get; set; }

	}
}
