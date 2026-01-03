using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPayrollAddition.procPayrollAdditionUpdate.procPayrollAdditionUpdateCommand
{

	/// @author  Shimels Alem  proc_Payroll_AdditionUpdate stored procedure.


	public class procPayrollAdditionUpdateCommand : IRequest<IList<PayrollAddition_Addion_ID>>
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

