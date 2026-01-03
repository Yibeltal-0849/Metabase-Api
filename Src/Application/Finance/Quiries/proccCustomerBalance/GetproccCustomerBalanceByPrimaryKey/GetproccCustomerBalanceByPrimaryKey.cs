using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccCustomerBalance.GetproccCustomerBalanceLoadAll;

namespace Application.Finance.Quiries.proccCustomerBalance.GetproccCustomerBalanceByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Customer_BalanceLoadByPrimaryKey stored procedure.

    public class GetproccCustomerBalanceByPrimaryKey : IRequest<GetproccCustomerBalanceLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
