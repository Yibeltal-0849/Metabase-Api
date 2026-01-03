using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procRentContract.GetprocRentContractLoadAll;

namespace Application.ProprtyData.Queries.procRentContract.GetprocRentContractByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_ContractLoadByPrimaryKey stored procedure.

    public class GetprocRentContractByPrimaryKey : IRequest<GetprocRentContractLoadAllListVm>
    {
        public System.Guid Rent_Contract_ID { get; set; }
    }
}
