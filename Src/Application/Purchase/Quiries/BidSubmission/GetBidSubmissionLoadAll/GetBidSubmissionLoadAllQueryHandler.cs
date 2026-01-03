using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidSubmission.GetBidSubmissionLoadAll
{
    class GetBidSubmissionLoadAllQueryHandler : IRequestHandler<GetBidSubmissionLoadAllQuery, GetBidSubmissionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidSubmissionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidSubmissionLoadAllListVm> Handle(GetBidSubmissionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Bid_Submission> BidSubmissions = await _procedureAdabter
               .Execute<Bid_Submission>("[Purchase].[proc_Bid_SubmissionLoadAll]");
            GetBidSubmissionLoadAllListVm vm = new GetBidSubmissionLoadAllListVm
            {
                BidSubmissions = _mapper.Map<IList<Bid_Submission>, IList<GetBidSubmissionLoadAllVm>>(BidSubmissions)
            };

            return vm;
        }
    }
}
