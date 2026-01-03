using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Pay_Slip.DeletePay_Slip
{
    /// @author  Shimels Alem  DeleteCPay_Slip stored procedure.
    
    public class DeletePay_SlipCommand : IRequest<IList<PaySlip_Pay_Slip_ID>>
    {
        public Guid Pay_Slip_ID { get; set; }
    }
}
