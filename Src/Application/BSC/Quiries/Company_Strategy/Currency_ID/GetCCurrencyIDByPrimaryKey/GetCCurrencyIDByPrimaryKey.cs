using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Currency_ID.GetCCurrencyIDLoadAll;

namespace XOKA.Application.BSC.Quiries.Currency_ID.GetCCurrencyIDByPrimaryKey
{
    public class GetCCurrencyIDByPrimaryKey : IRequest<GetCCurrencyIDLoadAllListVm>
    {
        public string CurrencyID { get; set; }
    }
}
