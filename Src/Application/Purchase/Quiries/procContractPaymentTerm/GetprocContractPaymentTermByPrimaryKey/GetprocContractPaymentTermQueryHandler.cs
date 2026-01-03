using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.procContractPaymentTerm.GetprocContractPaymentTermLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.procContractPaymentTerm.GetprocContractPaymentTermByPrimaryKey
{
    public class GetprocContractPaymentTermQueryHandler : IRequestHandler<GetprocContractPaymentTermByPrimaryKey, GetprocContractPaymentTermLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocContractPaymentTermQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocContractPaymentTermLoadAllListVm> Handle(GetprocContractPaymentTermByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ContractPaymentTerm> procContractPaymentTerms = await _procedureAdabter
               .Execute<ContractPaymentTerm>("[Purchase].[proc_Contract_PaymentTermLoadByPrimaryKey]", request);
            GetprocContractPaymentTermLoadAllListVm vm = new GetprocContractPaymentTermLoadAllListVm
            
            {
                procContractPaymentTerms = _mapper.Map<IList<ContractPaymentTerm>, IList<GetprocContractPaymentTermLoadAllVm>>(procContractPaymentTerms)
            };

            return vm;
        }
    }
}
