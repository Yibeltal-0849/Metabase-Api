


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CReceiveMoney.CReceiveMoneyInsert.CReceiveMoneyInsertCommand
{

    /// @author  Shimels Alem  C_Receive_MoneyInsert stored procedure.


    public class CReceiveMoneyInsertCommand : IRequest<IList<CReceiveMoney_Receipt_Number>>
    {
        public string Deposit_TicketID { get; set; }
        public string Reference { get; set; }
        public string Receipt_Number { get; set; }
        public string InvouceID { get; set; }
        public bool? ISCustomer { get; set; }
        public string CustomerID { get; set; }
        public string Vendor_ID { get; set; }
        public decimal? Receipt_Amount { get; set; }
        public long? Payment_Method { get; set; }
    }
		
		
		 
}
 
 