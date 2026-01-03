using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procCCurrencyID.GetprocCCurrencyIDLoadAll;

namespace Application.BSC.Quiries.procCCurrencyID.GetprocCCurrencyIDByPrimaryKey
{
    /// @author  Shimels Alem proc_C_Currency_IDLoadByPrimaryKey stored procedure.

    public class GetprocCCurrencyIDByPrimaryKey : IRequest<GetprocCCurrencyIDLoadAllListVm>
    {
        public string CurrencyID { get; set; }
    }
}
