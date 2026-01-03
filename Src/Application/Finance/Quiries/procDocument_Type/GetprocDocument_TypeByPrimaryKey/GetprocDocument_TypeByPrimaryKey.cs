using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procDocument_Type.GetprocDocument_TypeLoadAll;

namespace Application.Finance.Quiries.procDocument_Type.GetprocDocument_TypeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetprocDocument_TypeByPrimaryKey : IRequest<GetprocDocument_TypeLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
