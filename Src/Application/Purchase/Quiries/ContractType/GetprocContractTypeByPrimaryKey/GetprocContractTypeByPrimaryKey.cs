using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.ContractType.GetprocContractTypeLoadAll;


namespace Application.Purchase.Quiries.ContractType.GetprocContractTypeByPrimaryKey
{
    public class GetprocContractTypeByPrimaryKey : IRequest<GetprocContractTypeLoadAllListVm>

    {
        public string Code { get; set; }
    }
}
