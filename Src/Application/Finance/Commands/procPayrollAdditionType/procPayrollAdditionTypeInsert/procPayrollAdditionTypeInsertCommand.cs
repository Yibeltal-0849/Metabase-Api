


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace Application.Finance.Commands.procPayrollAdditionType.procPayrollAdditionTypeInsert.procPayrollAdditionTypeInsertCommand
{

    /// @author  Shimels Alem  proc_Payroll_Addition_TypeInsert stored procedure.


    public class procPayrollAdditionTypeInsertCommand : IRequest<IList<PayrollAdditionType_Addition_Type_code>>
    {
        public string Addition_Type_code { get; set; }
        public string Name { get; set; }
        public bool? Is_Taxable { get; set; }
        public double? Min_Value { get; set; }
        public double? Max_Value { get; set; }
        public string GL_Account { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 