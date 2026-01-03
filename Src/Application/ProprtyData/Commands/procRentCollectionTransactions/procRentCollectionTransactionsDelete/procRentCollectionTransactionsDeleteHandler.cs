using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollectionTransactions.procRentCollectionTransactionsDelete.procRentCollectionTransactionsDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class procRentCollectionTransactionsDeleteHandler : IRequestHandler<procRentCollectionTransactionsDeleteCommand, IList<RentCollectionTransactions>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRentCollectionTransactionsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentCollectionTransactions>> Handle( procRentCollectionTransactionsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<RentCollectionTransactions> result = await _procedureAdabter
                .Execute<RentCollectionTransactions>("[ProprtyData].proc_Rent_Collection_TransactionsDelete", request);
           

            return result;
        }
    }
}
  