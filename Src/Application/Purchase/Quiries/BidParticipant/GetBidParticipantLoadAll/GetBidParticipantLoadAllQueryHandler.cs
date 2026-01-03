using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidParticipant.GetBidParticipantLoadAll
{
    class GetBidParticipantLoadAllQueryHandler : IRequestHandler<GetBidParticipantLoadAllQuery, GetBidParticipantLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidParticipantLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidParticipantLoadAllListVm> Handle(GetBidParticipantLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Bid_Participant> BidParticipants = await _procedureAdabter
               .Execute<Bid_Participant>("[Purchase].[proc_Bid_ParticipantLoadAll]");
            GetBidParticipantLoadAllListVm vm = new GetBidParticipantLoadAllListVm
            {
                BidParticipants = _mapper.Map<IList<Bid_Participant>, IList<GetBidParticipantLoadAllVm>>(BidParticipants)
            };

            return vm;
        }
    }
}
