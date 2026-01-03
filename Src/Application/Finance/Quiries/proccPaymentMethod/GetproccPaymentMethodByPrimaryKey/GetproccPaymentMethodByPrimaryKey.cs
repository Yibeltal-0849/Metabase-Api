using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccPaymentMethod.GetproccPaymentMethodLoadAll;

namespace Application.Finance.Quiries.proccPaymentMethod.GetproccPaymentMethodByPrimaryKey
{
    /// @author  Shimels Alem proc_c_PaymentMethodLoadByPrimaryKey stored procedure.

    public class GetproccPaymentMethodByPrimaryKey : IRequest<GetproccPaymentMethodLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
