 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procPaySlip.procPaySlipDelete.procPaySlipDeleteCommand
{

    // @author  Shimels Alem  proc_Pay_SlipDelete stored procedure.


    public class procPaySlipDeleteCommand : IRequest<IList<PaySlip_Pay_Slip_ID>>
    {
        public System.Guid Pay_Slip_ID { get; set; }
    }
		
     
		
		 
}
 
 