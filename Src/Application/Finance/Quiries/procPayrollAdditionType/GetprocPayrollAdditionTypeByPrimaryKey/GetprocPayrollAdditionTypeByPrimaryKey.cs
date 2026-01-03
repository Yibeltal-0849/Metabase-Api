using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeLoadAll;

namespace Application.Finance.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Payroll_Addition_TypeLoadByPrimaryKey stored procedure.

    public class GetprocPayrollAdditionTypeByPrimaryKey : IRequest<GetprocPayrollAdditionTypeLoadAllListVm>
    {
        public string Addition_Type_code { get; set; }
    }
}
