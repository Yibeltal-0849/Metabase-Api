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

namespace Application.Purchase.Quiries.BidSubmission.GetBidSubmissionByPrimaryKey
{
    public class GetBidSubmissionQueryHandler : IRequestHandler<GetBidSubmissionByPrimaryKey, GetBidSubmissionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidSubmissionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidSubmissionLoadAllListVm> Handle(GetBidSubmissionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Bid_Submission> BidSubmissions = await _procedureAdabter
               .Execute<Bid_Submission>("[Purchase].[proc_Bid_SubmtionLoadByPrimaryKey]", request);
            GetBidSubmissionLoadAllListVm vm = new GetBidSubmissionLoadAllListVm
            {
                BidSubmissions = _mapper.Map<IList<Bid_Submission>, IList<GetBidSubmissionLoadAllVm>>(BidSubmissions)
            };

            return vm;
        }
    }
}
