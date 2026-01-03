using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionByPrimaryKey
{
    public class GetprocBacDataCollectionTransactionQueryHandler : IRequestHandler<GetprocBacDataCollectionTransactionByPrimaryKey, GetprocBacDataCollectionTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBacDataCollectionTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBacDataCollectionTransactionLoadAllListVm> Handle(GetprocBacDataCollectionTransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<BacDataCollectionTransaction> procBacDataCollectionTransactions = await _procedureAdabter
               .Execute<BacDataCollectionTransaction>("[BSC].[proc_Bac_Data_Collection_TransactionLoadByPrimaryKey]", request);
            GetprocBacDataCollectionTransactionLoadAllListVm vm = new GetprocBacDataCollectionTransactionLoadAllListVm
            {
                procBacDataCollectionTransactions = _mapper.Map<IList<BacDataCollectionTransaction>, IList<GetprocBacDataCollectionTransactionLoadAllVm>>(procBacDataCollectionTransactions)
            };

            return vm;
        }
    }
}
