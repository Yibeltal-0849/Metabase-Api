using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Chart_Of_Account;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Chart_Of_Account.UpdateCChartOfAccount
{
    public class UpdateCChartOfAccountCommand : GetCChartOfAccountLoadAllVm, IRequest<IList<Proc_C_Chart_Of_Account_Account_ID>>
    {
    }
}
