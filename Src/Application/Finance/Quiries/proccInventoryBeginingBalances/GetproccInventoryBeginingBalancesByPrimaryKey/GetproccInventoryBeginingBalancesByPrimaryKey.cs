using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccInventoryBeginingBalances.GetproccInventoryBeginingBalancesLoadAll;

namespace Application.Finance.Quiries.proccInventoryBeginingBalances.GetproccInventoryBeginingBalancesByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Inventory_Begining_BalancesLoadByPrimaryKey stored procedure.

    public class GetproccInventoryBeginingBalancesByPrimaryKey : IRequest<GetproccInventoryBeginingBalancesLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
