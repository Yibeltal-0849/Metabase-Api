using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidResult.BidResultDelete.BidResultDeleteCommand
{

    /// @author  Shimels Alem  Bid_ResultDelete stored procedure.


    public class BidResultDeleteHandler : IRequestHandler<BidResultDeleteCommand, IList<BidResult_BidResult>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidResultDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidResult_BidResult>> Handle( BidResultDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BidResult_BidResult> result = await _procedureAdabter
                .Execute<BidResult_BidResult>("[Purchase].Bid_ResultDelete", request);
           

            return result;
        }
    }
}
  