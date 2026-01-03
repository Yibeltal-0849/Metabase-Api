using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountLoadAll;

namespace Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccontforGrid
{
    /// @author  Shimels Alem proc_c_Chart_Of_AccountLoadByPrimaryKey stored procedure.

    public class GetproccChartOfAccontforGrid : IRequest<GetproccChartOfAccountLoadAllListVm>
    {
       // public string Account_ID { get; set; }
        public string Account_Purpose { get; set; }
        public int Chatagory_Id { get; set; }

    }
}
