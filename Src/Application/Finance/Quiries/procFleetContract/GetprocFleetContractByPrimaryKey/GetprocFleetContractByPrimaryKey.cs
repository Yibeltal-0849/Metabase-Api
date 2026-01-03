using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procFleetContract.GetprocFleetContractLoadAll;

namespace Application.Finance.Quiries.procFleetContract.GetprocFleetContractByPrimaryKey
{
    /// @author  Shimels Alem proc_Fleet_ContractLoadByPrimaryKey stored procedure.

    public class GetprocFleetContractByPrimaryKey : IRequest<GetprocFleetContractLoadAllListVm>
    {
        public string Contract_ID { get; set; }
    }
}
