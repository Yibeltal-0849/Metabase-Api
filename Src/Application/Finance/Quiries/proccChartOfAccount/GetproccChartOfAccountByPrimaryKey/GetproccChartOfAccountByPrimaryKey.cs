using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountLoadAll;

namespace Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Chart_Of_AccountLoadByPrimaryKey stored procedure.

    public class GetproccChartOfAccountByPrimaryKey : IRequest<GetproccChartOfAccountLoadAllListVm>
    {
        public string Account_ID { get; set; }
    }
}
