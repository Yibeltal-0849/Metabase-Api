using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procProportyDataCollectionTransaction.GetprocProportyDataCollectionTransactionLoadAll
{
    class GetprocProportyDataCollectionTransactionQueryHandler : IRequestHandler<GetprocProportyDataCollectionTransactionQuery, GetprocProportyDataCollectionTransactionListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProportyDataCollectionTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProportyDataCollectionTransactionListVm> Handle(GetprocProportyDataCollectionTransactionQuery request, CancellationToken cancellationToken)
        {
            IList<Proporty_Data_Collection_Transaction> procProportyDataCollection = await _procedureAdabter
               .Execute<Proporty_Data_Collection_Transaction>("[ProprtyData].[proc_Proporty_Data_Collection_TransactionLoadAll]");
            GetprocProportyDataCollectionTransactionListVm vm = new GetprocProportyDataCollectionTransactionListVm
            {
                procProportyDataCollection = _mapper.Map<IList<Proporty_Data_Collection_Transaction>, IList<GetprocProportyDataCollectionTransactionLoadAllVm>>(procProportyDataCollection)
            };

            return vm;
        }
    }
}
