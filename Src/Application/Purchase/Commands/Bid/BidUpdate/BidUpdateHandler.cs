

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;



namespace Application.Purchase.Commands.Bid.BidUpdate.BidUpdateCommand
{

    /// @author  Shimels Alem  proc_BidUpdate stored procedure.


    public class BidUpdateHandler : IRequestHandler<BidUpdateCommand, IList<_Bid_Bid_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Bid_Bid_ID>> Handle( BidUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<_Bid_Bid_ID> result = await _procedureAdabter
                .Execute<_Bid_Bid_ID>("[Purchase].proc_BidUpdate", request);
           

            return result;
        }
    }
}
 