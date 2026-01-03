using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccPayType.GetproccPayTypeLoadAll;

namespace Application.Finance.Quiries.proccPayType.GetproccPayTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_PayTypeLoadByPrimaryKey stored procedure.

    public class GetproccPayTypeByPrimaryKey : IRequest<GetproccPayTypeLoadAllListVm>
    {
        public string PayType { get; set; }
    }
}
