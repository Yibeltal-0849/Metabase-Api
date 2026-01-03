 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace Application.Finance.Commands.procPayrollAdditionType.procPayrollAdditionTypeDelete.procPayrollAdditionTypeDeleteCommand
{

    // @author  Shimels Alem  proc_Payroll_Addition_TypeDelete stored procedure.


    public class procPayrollAdditionTypeDeleteCommand : IRequest<IList<PayrollAdditionType_Addition_Type_code>>
    {
        public string Addition_Type_code { get; set; }
    }
		
     
		
		 
}
 
 