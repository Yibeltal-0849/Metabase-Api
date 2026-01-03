using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseLoadByPrimaryKeyApplicationNumber
{
    public class GetprocCTransactionPurchaseQueryHandler : IRequestHandler<GetprocCTransactionPurchaseLoadByPrimaryKeyApplicationNumber, GetprocCTransactionPurchaseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCTransactionPurchaseQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCTransactionPurchaseLoadAllListVm> Handle(GetprocCTransactionPurchaseLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
           
            IList<CTransactionPurchase> procCTransactionPurchases = await _procedureAdabter
               .Execute<CTransactionPurchase>("[FINA].[proc_CTransaction_PurchaseLoadByPrimaryKey_Application_Number]", request);
            GetprocCTransactionPurchaseLoadAllListVm vm = new GetprocCTransactionPurchaseLoadAllListVm
            {
                procCTransactionPurchases = _mapper.Map<IList<CTransactionPurchase>, IList<GetprocCTransactionPurchaseLoadAllVm>>(procCTransactionPurchases)
            };

            return vm;
        }
    }
}
