using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Addition_Type.DeletePayroll_Addition_Type
{
    /// @author  Shimels Alem  DeleteCPayroll_Addition_Type stored procedure.
    
    public class DeletePayroll_Addition_TypeCommand : IRequest<IList<PayrollAdditionType_Addition_Type_code>>
    {
        public Guid Addition_Type_code { get; set; }
    }
}
