using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CReceiveMoney.CReceiveMoneyUpdate.CReceiveMoneyUpdateCommand
{

	/// @author  Shimels Alem  C_Receive_MoneyUpdate stored procedure.


	public class CReceiveMoneyUpdateCommand : IRequest<IList<CReceiveMoney_Receipt_Number>>
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

