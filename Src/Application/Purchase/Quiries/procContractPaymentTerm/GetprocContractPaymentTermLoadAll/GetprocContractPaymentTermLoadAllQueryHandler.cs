using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.procContractPaymentTerm.GetprocContractPaymentTermLoadAll
{
    class GetprocContractPaymentTermLoadAllQueryHandler : IRequestHandler<GetprocContractPaymentTermLoadAllQuery, GetprocContractPaymentTermLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocContractPaymentTermLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocContractPaymentTermLoadAllListVm> Handle(GetprocContractPaymentTermLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ContractPaymentTerm> procContractPaymentTerms = await _procedureAdabter
               .Execute<ContractPaymentTerm>("[Purchase].[proc_Contract_PaymentTermLoadAll]");
            GetprocContractPaymentTermLoadAllListVm vm = new GetprocContractPaymentTermLoadAllListVm
            {
                procContractPaymentTerms = _mapper.Map<IList<ContractPaymentTerm>, IList<GetprocContractPaymentTermLoadAllVm>>(procContractPaymentTerms)
            };

            return vm;
        }
    }
}
