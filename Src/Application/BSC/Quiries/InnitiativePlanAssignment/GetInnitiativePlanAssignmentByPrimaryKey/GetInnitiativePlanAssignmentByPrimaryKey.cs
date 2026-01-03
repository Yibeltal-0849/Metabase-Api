using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.InnitiativePlanAssignment.GetInnitiativePlanAssignmentLoadAll;

namespace XOKA.Application.BSC.Quiries.InnitiativePlanAssignment.GetInnitiativePlanAssignmentByPrimaryKey
{
    /// @author  Shimels Alem  proc_Innitiative_Plan_AssignmentLoadByPrimaryKey stored procedure.

    public class GetInnitiativePlanAssignmentByPrimaryKey : IRequest<GetInnitiativePlanAssignmentLoadAllListVm>
    {
        public Guid IPA_ID { get; set; }
    }
}
