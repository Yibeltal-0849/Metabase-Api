using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Company_Strategy;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Company_Strategy.CreateCompanyStrategy
{
    public class CreateCompanyStrategyCommand : GetCompanyStrategyLoadAllVm, IRequest<IList<Proc_Company_Strategy_Strategy_NO>>
    {
    }
}
