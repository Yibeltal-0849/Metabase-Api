using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procFleetContract.GetprocFleetContractLoadAll;

namespace Application.Vehicle.Quiries.procFleetContract.GetprocFleetContractByPrimaryKey
{
    /// @author  Shimels Alem proc_Fleet_ContractLoadByPrimaryKey stored procedure.

    public class GetprocFleetContractByPrimaryKey : IRequest<GetprocFleetContractLoadAllListVm>
    {
        public string Contract_ID { get; set; }
    }
}
