using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionByPrimaryKey
{
    public class GetprocFixedAssetEntrustTransactionQueryHandler : IRequestHandler<GetprocFixedAssetEntrustTransactionByPrimaryKey, GetprocFixedAssetEntrustTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetEntrustTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetEntrustTransactionLoadAllListVm> Handle(GetprocFixedAssetEntrustTransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetEntrustTransaction> procFixedAssetEntrustTransactions = await _procedureAdabter
               .Execute<FixedAssetEntrustTransaction>("[FINA].[proc_Fixed_Asset_Entrust_TransactionLoadByPrimaryKey]", request);
            GetprocFixedAssetEntrustTransactionLoadAllListVm vm = new GetprocFixedAssetEntrustTransactionLoadAllListVm
            {
                procFixedAssetEntrustTransactions = _mapper.Map<IList<FixedAssetEntrustTransaction>, IList<GetprocFixedAssetEntrustTransactionLoadAllVm>>(procFixedAssetEntrustTransactions)
            };

            return vm;
        }
    }
}
