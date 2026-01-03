 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace Application.Finance.Commands.procPayrollAddition.procPayrollAdditionDelete.procPayrollAdditionDeleteCommand
{

    // @author  Shimels Alem  proc_Payroll_AdditionDelete stored procedure.


    public class procPayrollAdditionDeleteCommand : IRequest<IList<PayrollAddition_Addion_ID>>
    {

        public string Addion_ID { get; set; }
    }
		
     
		
		 
}
 
 