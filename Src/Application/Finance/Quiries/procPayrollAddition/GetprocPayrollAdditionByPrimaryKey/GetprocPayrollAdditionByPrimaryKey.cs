using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPayrollAddition.GetprocPayrollAdditionLoadAll;

namespace Application.Finance.Quiries.procPayrollAddition.GetprocPayrollAdditionByPrimaryKey
{
    /// @author  Shimels Alem proc_Payroll_AdditionLoadByPrimaryKey stored procedure.

    public class GetprocPayrollAdditionByPrimaryKey : IRequest<GetprocPayrollAdditionLoadAllListVm>
    {
        public string Addion_ID { get; set; }
    }
}
