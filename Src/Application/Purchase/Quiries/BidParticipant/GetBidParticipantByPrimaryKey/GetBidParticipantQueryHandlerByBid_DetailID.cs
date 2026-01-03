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
    public class GetBidParticipantQueryHandlerByBid_DetailID : IRequestHandler<GetBidParticipantByPrimaryKey_By_Bid_DetailID, GetBidParticipantLoadAllListVm_Bid_DetailID>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidParticipantQueryHandlerByBid_DetailID(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidParticipantLoadAllListVm_Bid_DetailID> Handle(GetBidParticipantByPrimaryKey_By_Bid_DetailID request, CancellationToken cancellationToken)
        {

            IList<Bid_Participant> Bid_DetailID = await _procedureAdabter
               .Execute<Bid_Participant>("[Purchase].[proc_Bid_ParticipantLoadByPrimaryKey_Bid_DetailID]", request);
            GetBidParticipantLoadAllListVm_Bid_DetailID vm = new GetBidParticipantLoadAllListVm_Bid_DetailID
            {
                Bid_DetailID = _mapper.Map<IList<Bid_Participant>, IList<GetBidParticipantLoadAllVm_by_Bid_DetailID>>(Bid_DetailID)
            };

            return vm;
        }
    }
}
