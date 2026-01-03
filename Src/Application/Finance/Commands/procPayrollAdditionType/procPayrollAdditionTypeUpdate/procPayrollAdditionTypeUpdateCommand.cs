using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPayrollAdditionType.procPayrollAdditionTypeUpdate.procPayrollAdditionTypeUpdateCommand
{

    /// @author  Shimels Alem  proc_Payroll_Addition_TypeUpdate stored procedure.


    public class procPayrollAdditionTypeUpdateCommand : IRequest<List<PayrollAdditionType_Addition_Type_code>>
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

