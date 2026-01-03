using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Addition_Type.CreatePayroll_Addition_Type
{
    /// @author  Shimels Alem  CreateCPayroll_Addition_Type stored procedure.
    
    public class CreatePayroll_Addition_TypeCommand : IRequest<IList<PayrollAdditionType_Addition_Type_code>>
    {
        public Guid Addition_Type_code { get; set; }
        public string Name { get; set; }
        public bool? Is_Taxable { get; set; }
        public double? Min_Value { get; set; }
        public double? Max_Value { get; set; }
        public string GL_Account { get; set; }
        public bool? Is_Active { get; set; }
    }
}
