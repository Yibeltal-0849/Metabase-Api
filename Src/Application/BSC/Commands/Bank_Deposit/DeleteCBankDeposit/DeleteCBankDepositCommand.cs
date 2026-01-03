using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Bank_Deposit.DeleteCBankDeposit
{
    public class DeleteCBankDepositCommand : IRequest<IList<Proc_C_Bank_Deposit_Id>>
    {
        public Guid Id { get; set; }
    }
}
