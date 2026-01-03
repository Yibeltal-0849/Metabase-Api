

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;



namespace Application.Purchase.Commands.BidAward.BidAwardUpdate.BidAwardUpdateCommand
{

    /// @author  Shimels Alem  proc_Bid_AwardUpdate stored procedure.


    public class BidAwardUpdateHandler : IRequestHandler<BidAwardUpdateCommand, IList<Bid_Award_Bid_Award_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidAwardUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Bid_Award_Bid_Award_ID>> Handle( BidAwardUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Bid_Award_Bid_Award_ID> result = await _procedureAdabter
                .Execute<Bid_Award_Bid_Award_ID>("[Purchase].proc_Bid_AwardUpdate", request);
           

            return result;
        }
    }
}
 