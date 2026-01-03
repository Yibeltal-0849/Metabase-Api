using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Currency_ID.DeleteCCurrencyID
{
    public class DeleteCCurrencyIDCommand : IRequest<IList<Proc_C_Currency_ID_CurrencyID>>
    {
        public string CurrencyID { get; set; }
    }
}
