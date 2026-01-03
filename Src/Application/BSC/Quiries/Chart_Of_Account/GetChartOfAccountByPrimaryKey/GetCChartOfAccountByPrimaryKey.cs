using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Chart_Of_Account.GetCChartOfAccountLoadAll;

namespace XOKA.Application.BSC.Quiries.Chart_Of_Account.GetCChartOfAccountByPrimaryKey
{
    public class GetCChartOfAccountByPrimaryKey : IRequest<GetCChartOfAccountLoadAllListVm>
    {
        public string Account_ID { get; set; }
    }
}
