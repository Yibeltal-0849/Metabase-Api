using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeLoadAll;

namespace Application.HRA.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Payroll_Addition_TypeLoadByPrimaryKey stored procedure.

    public class GetprocPayrollAdditionTypeByPrimaryKey : IRequest<GetprocPayrollAdditionTypeLoadAllListVm>
    {
        public Guid Addition_Type_code { get; set; }
    }
}
