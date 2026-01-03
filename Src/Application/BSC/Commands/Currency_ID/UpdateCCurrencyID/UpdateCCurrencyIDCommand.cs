using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Currency_ID;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Currency_ID.UpdateCCurrencyID
{
    public class UpdateCCurrencyIDCommand : GetCCurrencyIDLoadAllVm, IRequest<IList<Proc_C_Currency_ID_CurrencyID>>
    {
    }
}
