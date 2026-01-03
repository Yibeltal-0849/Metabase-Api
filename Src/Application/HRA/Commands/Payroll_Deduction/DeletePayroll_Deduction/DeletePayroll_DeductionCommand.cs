using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Deduction.DeletePayroll_Deduction
{
    /// @author  Shimels Alem  DeleteCPayroll_Deduction stored procedure.
    
    public class DeletePayroll_DeductionCommand : IRequest<IList<PayrollDeduction_Diduction_ID>>
    {
        public Guid Diduction_ID { get; set; }
    }
}
