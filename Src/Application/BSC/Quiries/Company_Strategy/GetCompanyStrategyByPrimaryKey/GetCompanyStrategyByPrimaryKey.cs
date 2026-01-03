using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Company_Strategy.GetCompanyStrategyLoadAll;

namespace XOKA.Application.BSC.Quiries.Company_Strategy.GetCompanyStrategyByPrimaryKey
{
    public class GetCompanyStrategyByPrimaryKey : IRequest<GetCompanyStrategyLoadAllListVm>
    {
        public string Strategy_NO { get; set; }
    }
}
