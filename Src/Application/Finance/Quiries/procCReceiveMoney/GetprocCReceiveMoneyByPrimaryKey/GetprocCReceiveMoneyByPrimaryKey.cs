using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCReceiveMoney.GetprocCReceiveMoneyLoadAll;

namespace Application.Finance.Quiries.procCReceiveMoney.GetprocCReceiveMoneyByPrimaryKey
{
    /// @author  Shimels Alem proc_C_Receive_MoneyLoadByPrimaryKey stored procedure.

    public class GetprocCReceiveMoneyByPrimaryKey : IRequest<GetprocCReceiveMoneyLoadAllListVm>
    {
        public string Receipt_Number { get; set; }
    }
}
