using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountLoadAll;

namespace Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountByPropose_Type
{
    /// @author  Shimels Alem proc_c_Chart_Of_AccountLoadByPrimaryKey stored procedure.

    public class GetproccChartOfAccountByPropose_Type : IRequest<GetproccChartOfAccountLoadAllListVm>
    {
        public string Propose_Type { get; set; }
    }
}
