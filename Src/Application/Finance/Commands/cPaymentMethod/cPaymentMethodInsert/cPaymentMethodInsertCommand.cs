


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPaymentMethod.cPaymentMethodInsert.cPaymentMethodInsertCommand
{

    /// @author  Shimels Alem  c_PaymentMethodInsert stored procedure.


    public class cPaymentMethodInsertCommand : IRequest<IList<CPaymentMethod_Id>>
    {
        public long Id { get; set; }
        public string Method { get; set; }
    }
		
		
		 
}
 
 