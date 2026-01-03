using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidOpening.BidOpeningDelete.BidOpeningDeleteCommand
{

    /// @author  Shimels Alem  proc_Bid_OpeningDelete stored procedure.


    public class BidOpeningDeleteHandler : IRequestHandler<BidOpeningDeleteCommand, IList<BidOpening_ParticipantID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidOpeningDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidOpening_ParticipantID>> Handle( BidOpeningDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BidOpening_ParticipantID> result = await _procedureAdabter
                .Execute<BidOpening_ParticipantID>("[Purchase].proc_Bid_OpeningDelete", request);
           

            return result;
        }
    }
}
  