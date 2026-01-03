

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;



namespace Application.Purchase.Commands.BidResult.BidResultUpdate.BidResultUpdateCommand
{

    /// @author  Shimels Alem  Bid_ResultUpdate stored procedure.


    public class BidResultUpdateHandler : IRequestHandler<BidResultUpdateCommand, IList<BidResult_BidResult>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidResultUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidResult_BidResult>> Handle( BidResultUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<BidResult_BidResult> result = await _procedureAdabter
                .Execute<BidResult_BidResult>("[Purchase].Bid_ResultUpdate", request);

            return result;
        }
    }
}
 