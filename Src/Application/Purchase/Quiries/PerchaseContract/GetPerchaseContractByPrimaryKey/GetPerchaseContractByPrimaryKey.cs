using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.PerchaseContract.GetPerchaseContractLoadAll;

namespace Application.Purchase.Quiries.PerchaseContract.GetPerchaseContractByPrimaryKey
{
    /// @author  Shimels Alem proc_Perchase_ContractLoadByPrimaryKey stored procedure.

    public class GetPerchaseContractByPrimaryKey : IRequest<GetPerchaseContractLoadAllListVm>
    {
        public string Purchase_Contract { get; set; }
    }
}
