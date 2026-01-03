using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Bank_Deposit.GetCBankDepositLoadAll;

namespace XOKA.Application.BSC.Quiries.Bank_Deposit.GetprocCBankDepositLoadByPrimaryKeyDepositTicketID
{
    public class GetprocCBankDepositLoadByPrimaryKeyDepositTicketID : IRequest<GetCBankDepositLoadAllListVm>
    {
        public string Deposit_Ticket_ID { get; set; }
    }
}
