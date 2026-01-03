 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPaymentMethod.cPaymentMethodDelete.cPaymentMethodDeleteCommand
{

    // @author  Shimels Alem  c_PaymentMethodDelete stored procedure.


    public class cPaymentMethodDeleteCommand : IRequest<IList<CPaymentMethod_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 