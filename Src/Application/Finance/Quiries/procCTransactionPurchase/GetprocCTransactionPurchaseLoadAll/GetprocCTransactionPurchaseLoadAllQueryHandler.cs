using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseLoadAll
{
    class GetprocCTransactionPurchaseLoadAllQueryHandler : IRequestHandler<GetprocCTransactionPurchaseLoadAllQuery, GetprocCTransactionPurchaseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCTransactionPurchaseLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCTransactionPurchaseLoadAllListVm> Handle(GetprocCTransactionPurchaseLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CTransactionPurchase> procCTransactionPurchases = await _procedureAdabter
               .Execute<CTransactionPurchase>("[FINA].[proc_CTransaction_PurchaseLoadAll]");
            GetprocCTransactionPurchaseLoadAllListVm vm = new GetprocCTransactionPurchaseLoadAllListVm
            {
                procCTransactionPurchases = _mapper.Map<IList<CTransactionPurchase>, IList<GetprocCTransactionPurchaseLoadAllVm>>(procCTransactionPurchases)
            };

            return vm;
        }
    }
}
