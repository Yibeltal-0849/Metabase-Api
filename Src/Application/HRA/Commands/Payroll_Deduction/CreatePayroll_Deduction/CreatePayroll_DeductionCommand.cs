using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Deduction.CreatePayroll_Deduction
{
    /// @author  Shimels Alem  CreateCPayroll_Deduction stored procedure.
    
    public class CreatePayroll_DeductionCommand : IRequest<IList<PayrollDeduction_Diduction_ID>>
    {
        public System.Guid? Diduction_ID { get; set; }
        public System.Guid? Pos_ID { get; set; }
        public System.Guid? Diducation_Type { get; set; }
        public string Unit { get; set; }
        public double? QTY { get; set; }
        public double? Unit_Price { get; set; }
        //public double? Total_Amount { get; set; }
        //public System.DateTime? StartDate { get; set; }
        //public System.DateTime? End_Date { get; set; }
        public bool? is_Active { get; set; }
        public string Remark { get; set; }
        public bool? Is_Personal { get; set; }
        //public string Employee_ID { get; set; }
    }
}
