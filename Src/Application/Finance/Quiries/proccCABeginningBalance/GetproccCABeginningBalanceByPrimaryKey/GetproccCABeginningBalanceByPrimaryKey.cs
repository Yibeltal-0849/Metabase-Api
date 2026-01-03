using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccCABeginningBalance.GetproccCABeginningBalanceLoadAll;

namespace Application.Finance.Quiries.proccCABeginningBalance.GetproccCABeginningBalanceByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetproccCABeginningBalanceByPrimaryKey : IRequest<GetproccCABeginningBalanceLoadAllListVm>
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
    }
}
