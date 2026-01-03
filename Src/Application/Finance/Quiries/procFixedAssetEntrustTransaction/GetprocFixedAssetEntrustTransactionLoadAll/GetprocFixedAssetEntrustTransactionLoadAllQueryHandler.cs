using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadAll
{
    class GetprocFixedAssetEntrustTransactionLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetEntrustTransactionLoadAllQuery, GetprocFixedAssetEntrustTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetEntrustTransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetEntrustTransactionLoadAllListVm> Handle(GetprocFixedAssetEntrustTransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetEntrustTransaction> procFixedAssetEntrustTransactions = await _procedureAdabter
               .Execute<FixedAssetEntrustTransaction>("[FINA].[proc_Fixed_Asset_Entrust_TransactionLoadAll]");
            GetprocFixedAssetEntrustTransactionLoadAllListVm vm = new GetprocFixedAssetEntrustTransactionLoadAllListVm
            {
                procFixedAssetEntrustTransactions = _mapper.Map<IList<FixedAssetEntrustTransaction>, IList<GetprocFixedAssetEntrustTransactionLoadAllVm>>(procFixedAssetEntrustTransactions)
            };

            return vm;
        }
    }
}
