


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace Application.Finance.Commands.procPayrollAddition.procPayrollAdditionInsert.procPayrollAdditionInsertCommand
{

    /// @author  Shimels Alem  proc_Payroll_AdditionInsert stored procedure.


    public class procPayrollAdditionInsertCommand : IRequest<IList<PayrollAddition_Addion_ID>>
    {
        public string Addion_ID { get; set; }
        public string Emplyee_ID { get; set; }
        public string Addition_Type { get; set; }
        public string Unit { get; set; }
        public int? QTY { get; set; }
        public double? Unit_Price { get; set; }
        public double Amount { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 