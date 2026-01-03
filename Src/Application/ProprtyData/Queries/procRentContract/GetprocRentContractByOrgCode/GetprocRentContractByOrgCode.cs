using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procRentContract.GetprocRentContractLoadAll;

namespace Application.ProprtyData.Queries.procRentContract.GetprocRentContractByOrgCode
{
    public class GetprocRentContractByOrgCode : IRequest<GetprocRentContractLoadAllListVm>
    {
        public System.Guid From_Organization_Code { get; set; }
    }
}
