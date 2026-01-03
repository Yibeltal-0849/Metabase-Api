using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmployeePay_Slip.UpdateCEmployeePay_Slip
{
    /// @author  Shimels Alem  UpdateCEmployeePay_Slip stored procedure.
    
    public class UpdateCEmployeePay_SlipCommand : IRequest<IList<PaySlip_Pay_Slip_ID>>
    {
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Payroll_Trans_ID { get; set; }
    }
}
