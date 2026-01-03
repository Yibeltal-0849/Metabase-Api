using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Quiries.procRentCollectionTransactions.GetprocRentCollectionTransactionsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.procRentCollectionTransactions.GetprocRentCollectionTransactionsByPrimaryKey
{
    public class GetprocRentCollectionTransactionsQueryHandler : IRequestHandler<GetprocRentCollectionTransactionsByPrimaryKey, GetprocRentCollectionTransactionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRentCollectionTransactionsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentCollectionTransactionsLoadAllListVm> Handle(GetprocRentCollectionTransactionsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<RentCollectionTransactions> procRentCollectionTransactionss = await _procedureAdabter
               .Execute<RentCollectionTransactions>("[ProprtyData].[proc_Rent_Collection_TransactionsLoadByPrimaryKey]", request);
            GetprocRentCollectionTransactionsLoadAllListVm vm = new GetprocRentCollectionTransactionsLoadAllListVm
            {
                procRentCollectionTransactionss = _mapper.Map<IList<RentCollectionTransactions>, IList<GetprocRentCollectionTransactionsLoadAllVm>>(procRentCollectionTransactionss)
            };

            return vm;
        }
    }
}
