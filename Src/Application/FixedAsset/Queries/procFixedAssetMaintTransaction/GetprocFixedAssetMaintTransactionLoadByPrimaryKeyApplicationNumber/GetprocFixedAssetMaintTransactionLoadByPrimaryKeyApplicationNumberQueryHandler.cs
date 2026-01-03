using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.GetprocFixedAssetMaintTransactionLoadAll;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.procFixedAssetMaintTransactionLoadByPrimaryKeyApplicationNumber
{
    public class GetprocFixedAssetMaintTransactionQueryHandler : IRequestHandler<procFixedAssetMaintTransactionLoadByPrimaryKeyApplicationNumber, GetprocFixedAssetMaintTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetMaintTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetMaintTransactionLoadAllListVm> Handle(procFixedAssetMaintTransactionLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetMaintTransaction> procFixedAssetMaintTransactions = await _procedureAdabter
               .Execute<FixedAssetMaintTransaction>("[FixedAsset].[proc_Fixed_Asset_Maint_TransactionLoadByPrimaryKey_Application_Number]", request);
            GetprocFixedAssetMaintTransactionLoadAllListVm vm = new GetprocFixedAssetMaintTransactionLoadAllListVm
            {
                procFixedAssetMaintTransactions = _mapper.Map<IList<FixedAssetMaintTransaction>, IList<GetprocFixedAssetMaintTransactionLoadAllVm>>(procFixedAssetMaintTransactions)
            };

            return vm;
        }
    }
}
