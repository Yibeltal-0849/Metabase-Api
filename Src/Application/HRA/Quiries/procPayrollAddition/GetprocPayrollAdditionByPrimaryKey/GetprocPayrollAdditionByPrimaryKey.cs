using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procPayrollAddition.GetprocPayrollAdditionLoadAll;

namespace Application.HRA.Quiries.procPayrollAddition.GetprocPayrollAdditionByPrimaryKey
{
    /// @author  Shimels Alem proc_Payroll_AdditionLoadByPrimaryKey stored procedure.

    public class GetprocPayrollAdditionByPrimaryKey : IRequest<GetprocPayrollAdditionLoadAllListVm>
    {
        public Guid Addion_ID { get; set; }
    }
}
