



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;


namespace Application.Purchase.Commands.BidResult.BidResultInsert.BidResultInsertCommand
{

    /// @author  Shimels Alem  Bid_ResultInsert stored procedure.


    public class BidResultInsertHandler : IRequestHandler<BidResultInsertCommand, IList<BidResult_BidResult>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidResultInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidResult_BidResult>> Handle( BidResultInsertCommand request, CancellationToken cancellationToken)
        {

            IList<BidResult_BidResult> result = await _procedureAdabter
                .Execute<BidResult_BidResult>("[Purchase].Bid_ResultInsert", request);
           

            return result;
        }
    }
}
 