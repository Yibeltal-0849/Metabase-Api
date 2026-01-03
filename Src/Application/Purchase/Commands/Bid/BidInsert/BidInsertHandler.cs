



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;


namespace Application.Purchase.Commands.Bid.BidInsert.BidInsertCommand
{

    /// @author  Shimels Alem  proc_BidInsert stored procedure.


    public class BidInsertHandler : IRequestHandler<BidInsertCommand, IList<_Bid_Bid_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Bid_Bid_ID>> Handle( BidInsertCommand request, CancellationToken cancellationToken)
        {

            IList<_Bid_Bid_ID> result = await _procedureAdabter
                .Execute<_Bid_Bid_ID>("[Purchase].proc_BidInsert", request);
           

            return result;
        }
    }
}
 