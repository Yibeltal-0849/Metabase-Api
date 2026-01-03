using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procPayrollDeduction.GetprocPayrollDeductionLoadAll;

namespace Application.HRA.Quiries.procPayrollDeduction.GetprocPayrollDeductionByPrimaryKey
{
    /// @author  Shimels Alem proc_Payroll_DeductionLoadByPrimaryKey stored procedure.

    public class GetprocPayrollDeductionByPrimaryKey : IRequest<GetprocPayrollDeductionLoadAllListVm>
    {
        public System.Guid Diduction_ID { get; set; }
    }
}
