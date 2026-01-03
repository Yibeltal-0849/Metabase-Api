using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadAll;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadByPrimaryKeyaplicationnumber
{
    public class GetprocFixedAssetEntrustTransactionQueryHandler : IRequestHandler<GetprocFixedAssetEntrustTransactionLoadByPrimaryKeyaplicationnumber, GetprocFixedAssetEntrustTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetEntrustTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetEntrustTransactionLoadAllListVm> Handle(GetprocFixedAssetEntrustTransactionLoadByPrimaryKeyaplicationnumber request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetEntrustTransaction> procFixedAssetEntrustTransactions = await _procedureAdabter
               .Execute<FixedAssetEntrustTransaction>("[FixedAsset].[proc_Fixed_Asset_Entrust_TransactionLoadByPrimaryKey_aplication_number]", request);
            GetprocFixedAssetEntrustTransactionLoadAllListVm vm = new GetprocFixedAssetEntrustTransactionLoadAllListVm
            {
                procFixedAssetEntrustTransactions = _mapper.Map<IList<FixedAssetEntrustTransaction>, IList<GetprocFixedAssetEntrustTransactionLoadAllVm>>(procFixedAssetEntrustTransactions)
            };

            return vm;
        }
    }
}
