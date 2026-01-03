using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.TransactionProportyAssignment.GetTransactionProportyAssignmentLoadAll;

namespace XOKA.Application.HRA.Quiries.TransactionProportyAssignment.GetTransactionProportyAssignmentByPrimaryKey
{
    /// @author  Shimels Alem  proc_C_EmployeeLoadByPrimaryKey stored procedure.

    public class GetTransactionProportyAssignmentByPrimaryKey : IRequest<GetTransactionProportyAssignmentListVm>
    {
        public System.Guid Trasn_Id { get; set; }
    }
}
