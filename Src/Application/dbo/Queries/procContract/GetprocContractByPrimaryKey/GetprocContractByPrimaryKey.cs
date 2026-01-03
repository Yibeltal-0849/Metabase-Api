using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procContract.GetprocContractLoadAll;

namespace Application.dbo.Quiries.procContract.GetprocContractByPrimaryKey
{
    /// @author  Shimels Alem proc_ContractLoadByPrimaryKey stored procedure.

    public class GetprocContractByPrimaryKey : IRequest<GetprocContractLoadAllListVm>
    {
        public string Contract_No { get; set; }
    }
}
