using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPTransactionPurchaseType.GetprocPTransactionPurchaseTypeLoadAll
{
    class GetprocPTransactionPurchaseTypeLoadAllQueryHandler : IRequestHandler<GetprocPTransactionPurchaseTypeLoadAllQuery, GetprocPTransactionPurchaseTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPTransactionPurchaseTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPTransactionPurchaseTypeLoadAllListVm> Handle(GetprocPTransactionPurchaseTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PTransactionPurchaseType> procPTransactionPurchaseTypes = await _procedureAdabter
               .Execute<PTransactionPurchaseType>("[FINA].[proc_P_Transaction Purchase TypeLoadAll]");
            GetprocPTransactionPurchaseTypeLoadAllListVm vm = new GetprocPTransactionPurchaseTypeLoadAllListVm
            {
                procPTransactionPurchaseTypes = _mapper.Map<IList<PTransactionPurchaseType>, IList<GetprocPTransactionPurchaseTypeLoadAllVm>>(procPTransactionPurchaseTypes)
            };

            return vm;
        }
    }
}
