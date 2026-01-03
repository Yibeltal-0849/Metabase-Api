using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.procRentCollectionTransactions.GetprocRentCollectionTransactionsLoadAll
{
    class GetprocRentCollectionTransactionsLoadAllQueryHandler : IRequestHandler<GetprocRentCollectionTransactionsLoadAllQuery, GetprocRentCollectionTransactionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocRentCollectionTransactionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentCollectionTransactionsLoadAllListVm> Handle(GetprocRentCollectionTransactionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<RentCollectionTransactions> procRentCollectionTransactionss = await _procedureAdabter
               .Execute<RentCollectionTransactions>("[ProprtyData].[proc_Rent_Collection_TransactionsLoadAll]");
            GetprocRentCollectionTransactionsLoadAllListVm vm = new GetprocRentCollectionTransactionsLoadAllListVm
            {
                procRentCollectionTransactionss = _mapper.Map<IList<RentCollectionTransactions>, IList<GetprocRentCollectionTransactionsLoadAllVm>>(procRentCollectionTransactionss)
            };

            return vm;
        }
    }
}
