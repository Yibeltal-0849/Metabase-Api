

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollectionTransactions.procRentCollectionTransactionsUpdate.procRentCollectionTransactionsUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXXX stored procedure.
	 
	 
      public class procRentCollectionTransactionsUpdateHandler : IRequestHandler<procRentCollectionTransactionsUpdateCommand, IList<RentCollectionTransactions>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRentCollectionTransactionsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentCollectionTransactions>> Handle( procRentCollectionTransactionsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<RentCollectionTransactions> result = await _procedureAdabter
                .Execute<RentCollectionTransactions>("[ProprtyData].XXXXx", request);
           

            return result;
        }
    }
}
 