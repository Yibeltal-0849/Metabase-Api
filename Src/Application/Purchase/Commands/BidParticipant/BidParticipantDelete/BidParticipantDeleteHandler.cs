using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidParticipant.BidParticipantDelete.BidParticipantDeleteCommand
{

    /// @author  Shimels Alem  proc_Bid_ParticipantDelete stored procedure.


    public class BidParticipantDeleteHandler : IRequestHandler<BidParticipantDeleteCommand, IList<Bid_Participant_Participant_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidParticipantDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Bid_Participant_Participant_ID>> Handle( BidParticipantDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Bid_Participant_Participant_ID> result = await _procedureAdabter
                .Execute<Bid_Participant_Participant_ID>("[Purchase].proc_Bid_ParticipantDelete", request);
           

            return result;
        }
    }
}
  