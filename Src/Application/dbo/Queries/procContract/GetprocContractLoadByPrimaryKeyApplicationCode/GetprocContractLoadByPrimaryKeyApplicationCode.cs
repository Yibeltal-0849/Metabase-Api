using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procContract.GetprocContractLoadAll;

namespace Application.dbo.Quiries.procContract.GetprocContractLoadByPrimaryKeyApplicationCode
{
    /// @author  Shimels Alem proc_ContractLoadByPrimaryKey_Application_Code stored procedure.

    public class GetprocContractLoadByPrimaryKeyApplicationCode : IRequest<GetprocContractLoadAllListVm>
    {
        public Guid Application_Code { get; set; }
    }
}
