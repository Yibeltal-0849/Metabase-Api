using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.BidParticipant.GetBidParticipantLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidParticipant.GetBidParticipantByPrimaryKey
{
    public class GetBidParticipantQueryHandler : IRequestHandler<GetBidParticipantByPrimaryKey, GetBidParticipantLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidParticipantQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidParticipantLoadAllListVm> Handle(GetBidParticipantByPrimaryKey request, CancellationToken cancellationToken)
        {

            IList<Bid_Participant> BidParticipants = await _procedureAdabter
               .Execute<Bid_Participant>("[Purchase].[proc_Bid_ParticipantLoadByPrimaryKey]", request);
            GetBidParticipantLoadAllListVm vm = new GetBidParticipantLoadAllListVm
            {
                BidParticipants = _mapper.Map<IList<Bid_Participant>, IList<GetBidParticipantLoadAllVm>>(BidParticipants)
            };

            return vm;
        }
    }
}
