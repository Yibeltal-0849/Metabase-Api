using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Bank_Deposit.GetCBankDepositLoadAll;

namespace XOKA.Application.BSC.Quiries.Bank_Deposit.GetCBankDepositByPrimaryKey
{
    public class GetCBankDepositByPrimaryKey : IRequest<GetCBankDepositLoadAllListVm>
    {
        public Guid Id { get; set; }
    }
}
