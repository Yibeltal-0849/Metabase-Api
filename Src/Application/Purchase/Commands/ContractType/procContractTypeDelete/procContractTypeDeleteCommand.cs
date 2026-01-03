using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.ContractType.procContractTypeDelete
{
    public class procContractTypeDeleteCommand : IRequest<IList<ReciveContractType_Code>>
    {
        public string Code { get; set; }
    }
}

 