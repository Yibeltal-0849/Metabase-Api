using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionLoadAll
{
    class GetprocFixedAssetManagementTransactionLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetManagementTransactionLoadAllQuery, GetprocFixedAssetManagementTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetManagementTransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetManagementTransactionLoadAllListVm> Handle(GetprocFixedAssetManagementTransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetManagementTransaction> procFixedAssetManagementTransactions = await _procedureAdabter
               .Execute<FixedAssetManagementTransaction>("[FixedAsset].[proc_Fixed_Asset_Management_TransactionLoadAll]");
            GetprocFixedAssetManagementTransactionLoadAllListVm vm = new GetprocFixedAssetManagementTransactionLoadAllListVm
            {
                procFixedAssetManagementTransactions = _mapper.Map<IList<FixedAssetManagementTransaction>, IList<GetprocFixedAssetManagementTransactionLoadAllVm>>(procFixedAssetManagementTransactions)
            };

            return vm;
        }
    }
}
