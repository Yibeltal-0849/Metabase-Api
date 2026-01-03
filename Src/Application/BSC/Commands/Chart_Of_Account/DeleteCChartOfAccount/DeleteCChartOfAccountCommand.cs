using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Chart_Of_Account.DeleteCChartOfAccount
{
    public class DeleteCChartOfAccountCommand : IRequest<IList<Proc_C_Chart_Of_Account_Account_ID>>
    {
        public string Account_ID { get; set; }
    }
}
