using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.GetprocFixedAssetMaintTransactionLoadAll
{
    class GetprocFixedAssetMaintTransactionLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetMaintTransactionLoadAllQuery, GetprocFixedAssetMaintTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetMaintTransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetMaintTransactionLoadAllListVm> Handle(GetprocFixedAssetMaintTransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetMaintTransaction> procFixedAssetMaintTransactions = await _procedureAdabter
               .Execute<FixedAssetMaintTransaction>("[FixedAsset].[proc_Fixed_Asset_Maint_TransactionLoadAll]");
            GetprocFixedAssetMaintTransactionLoadAllListVm vm = new GetprocFixedAssetMaintTransactionLoadAllListVm
            {
                procFixedAssetMaintTransactions = _mapper.Map<IList<FixedAssetMaintTransaction>, IList<GetprocFixedAssetMaintTransactionLoadAllVm>>(procFixedAssetMaintTransactions)
            };

            return vm;
        }
    }
}
