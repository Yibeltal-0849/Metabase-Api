 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CReceiveMoney.CReceiveMoneyDelete.CReceiveMoneyDeleteCommand
{

    // @author  Shimels Alem  C_Receive_MoneyDelete stored procedure.


    public class CReceiveMoneyDeleteCommand : IRequest<IList<CReceiveMoney_Receipt_Number>>
    {
        public string ReceiptNumber { get; set; }
    }
		
     
		
		 
}
 
 