using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidDetail.BidDetailDelete.BidDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_Bid_DetailDelete stored procedure.


    public class BidDetailDeleteHandler : IRequestHandler<BidDetailDeleteCommand, IList<Bid_Detail_Bid_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Bid_Detail_Bid_DetailID>> Handle( BidDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Bid_Detail_Bid_DetailID> result = await _procedureAdabter
                .Execute<Bid_Detail_Bid_DetailID>("[Purchase].proc_Bid_DetailDelete", request);
           

            return result;
        }
    }
}
  