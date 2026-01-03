using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payroll_Addition.UpdatePayroll_Addition
{
    /// @author  Shimels Alem  UpdateCPayroll_Addition stored procedure.
    
    public class UpdatePayroll_AdditionCommand : IRequest<IList<PayrollAddition_Addion_ID>>
    {
        public Guid Addion_ID { get; set; }
        public Guid Pos_ID { get; set; }
        public Guid Addition_Type { get; set; }
        public string Unit { get; set; }
        public double? QTY { get; set; }
        public double? Unit_Price { get; set; }
     
        public bool? Is_Active { get; set; }
        public bool? Is_Personal { get; set; }
      
    }
}
