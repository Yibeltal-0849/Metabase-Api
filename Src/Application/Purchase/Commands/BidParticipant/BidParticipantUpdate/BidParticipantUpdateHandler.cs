

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;



namespace Application.Purchase.Commands.BidParticipant.BidParticipantUpdate.BidParticipantUpdateCommand
{

    /// @author  Shimels Alem  proc_Bid_ParticipantUpdate stored procedure.


    public class BidParticipantUpdateHandler : IRequestHandler<BidParticipantUpdateCommand, IList<Bid_Participant_Participant_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidParticipantUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Bid_Participant_Participant_ID>> Handle( BidParticipantUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Bid_Participant_Participant_ID> result = await _procedureAdabter
                .Execute<Bid_Participant_Participant_ID>("[Purchase].proc_Bid_ParticipantUpdate", request);
           

            return result;
        }
    }
}
 