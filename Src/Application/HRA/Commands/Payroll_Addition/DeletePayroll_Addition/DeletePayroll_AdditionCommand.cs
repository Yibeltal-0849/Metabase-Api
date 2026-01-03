using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Addition.DeletePayroll_Addition
{
    /// @author  Shimels Alem  DeleteCPayroll_Addition stored procedure.
    
    public class DeletePayroll_AdditionCommand : IRequest<IList<PayrollAddition_Addion_ID>>
    {
        public string Addion_ID { get; set; }
    }
}
