using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPBlanketpurchaseorder.GetprocPBlanketpurchaseorderLoadAll;

namespace Application.Finance.Quiries.procPBlanketpurchaseorder.GetprocPBlanketpurchaseorderByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Blanket purchase orderLoadByPrimaryKey] stored procedure.

    public class GetprocPBlanketpurchaseorderByPrimaryKey : IRequest<GetprocPBlanketpurchaseorderLoadAllListVm>
    {
        public System.Guid Purchase_Line { get; set; }
    }
}
