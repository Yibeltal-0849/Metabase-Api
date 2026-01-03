using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.BidSubmission.GetBidSubmissionLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidSubmission.GetprocBidSubmissionLoadByPrimaryKeyPrticipantID
{
    public class GetBidSubmissionQueryHandler : IRequestHandler<GetprocBidSubmissionLoadByPrimaryKeyPrticipantID, GetBidSubmissionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidSubmissionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidSubmissionLoadAllListVm> Handle(GetprocBidSubmissionLoadByPrimaryKeyPrticipantID request, CancellationToken cancellationToken)
        {
           
            IList<Bid_Submission> BidSubmissions = await _procedureAdabter
               .Execute<Bid_Submission>("[Purchase].[proc_Bid_SubmissionLoadByPrimaryKey_Prticipant_ID]", request);
            GetBidSubmissionLoadAllListVm vm = new GetBidSubmissionLoadAllListVm
            {
                BidSubmissions = _mapper.Map<IList<Bid_Submission>, IList<GetBidSubmissionLoadAllVm>>(BidSubmissions)
            };

            return vm;
        }
    }
}
