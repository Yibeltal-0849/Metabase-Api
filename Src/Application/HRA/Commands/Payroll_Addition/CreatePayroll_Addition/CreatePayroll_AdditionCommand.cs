using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Addition.CreatePayroll_Addition
{
    /// @author  Shimels Alem  CreateCPayroll_Addition stored procedure.
    
    public class CreatePayroll_AdditionCommand : IRequest<IList<PayrollAddition_Addion_ID>>
    {
        public Guid Addion_ID { get; set; }
        public Guid Pos_ID { get; set; }
        public Guid Addition_Type { get; set; }
        public string Unit { get; set; }
        public double? QTY { get; set; }
        public double? Unit_Price { get; set; }
        //public double Amount { get; set; }
        //public DateTime? Start_Date { get; set; }
        //public DateTime? End_Date { get; set; }
        public bool? Is_Active { get; set; }
        public bool? Is_Personal { get; set; }
        //public string Employee_ID { get; set; }
    }
}
