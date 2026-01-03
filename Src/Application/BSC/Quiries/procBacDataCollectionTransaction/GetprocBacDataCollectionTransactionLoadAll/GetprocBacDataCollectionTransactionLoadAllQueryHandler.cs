using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionLoadAll
{
    class GetprocBacDataCollectionTransactionLoadAllQueryHandler : IRequestHandler<GetprocBacDataCollectionTransactionLoadAllQuery, GetprocBacDataCollectionTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBacDataCollectionTransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBacDataCollectionTransactionLoadAllListVm> Handle(GetprocBacDataCollectionTransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<BacDataCollectionTransaction> procBacDataCollectionTransactions = await _procedureAdabter
               .Execute<BacDataCollectionTransaction>("[BSC].[proc_Bac_Data_Collection_TransactionLoadAll]");
            GetprocBacDataCollectionTransactionLoadAllListVm vm = new GetprocBacDataCollectionTransactionLoadAllListVm
            {
                procBacDataCollectionTransactions = _mapper.Map<IList<BacDataCollectionTransaction>, IList<GetprocBacDataCollectionTransactionLoadAllVm>>(procBacDataCollectionTransactions)
            };

            return vm;
        }
    }
}
