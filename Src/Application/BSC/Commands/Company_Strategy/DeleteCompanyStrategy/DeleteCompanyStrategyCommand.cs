using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Company_Strategy.DeleteCompanyStrategy
{
    public class DeleteCompanyStrategyCommand : IRequest<IList<Proc_Company_Strategy_Strategy_NO>>
    {
        public string Strategy_NO { get; set; }
    }
}
