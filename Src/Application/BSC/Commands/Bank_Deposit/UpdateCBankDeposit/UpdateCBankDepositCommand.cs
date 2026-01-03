using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Bank_Deposit;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Bank_Deposit.UpdateCBankDeposit
{
    public class UpdateCBankDepositCommand : GetCBankDepositLoadAllVm, IRequest<IList<Proc_C_Bank_Deposit_Id>>
    {
    }
}
