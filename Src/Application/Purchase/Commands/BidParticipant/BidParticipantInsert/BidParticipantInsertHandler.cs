



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;


namespace Application.Purchase.Commands.BidParticipant.BidParticipantInsert.BidParticipantInsertCommand
{

    /// @author  Shimels Alem  proc_Bid_ParticipantInsert stored procedure.


    public class BidParticipantInsertHandler : IRequestHandler<BidParticipantInsertCommand, IList<Bid_Participant_Participant_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidParticipantInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Bid_Participant_Participant_ID>> Handle( BidParticipantInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Bid_Participant_Participant_ID> result = await _procedureAdabter
                .Execute<Bid_Participant_Participant_ID>("[Purchase].proc_Bid_ParticipantInsert", request);
           

            return result;
        }
    }
}
 