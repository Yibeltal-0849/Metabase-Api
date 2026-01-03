using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.Bid.GetBidLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.Bid.GetprocBidLoadByPrimaryKeyApplicationuserName
{
    public class GetBidQueryHandler : IRequestHandler<GetprocBidLoadByPrimaryKeyApplicationuserName, GetBidLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidLoadAllListVm> Handle(GetprocBidLoadByPrimaryKeyApplicationuserName request, CancellationToken cancellationToken)
        {
           
            IList<_Bid> Bids = await _procedureAdabter
               .Execute<_Bid>("[Purchase].[proc_BidLoadByPrimaryKey_Application_userid]", request);
            GetBidLoadAllListVm vm = new GetBidLoadAllListVm
            {
                Bids = _mapper.Map<IList<_Bid>, IList<GetBidLoadAllVm>>(Bids)
            };

            return vm;
        }
    }
}
