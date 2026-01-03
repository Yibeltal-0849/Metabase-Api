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

namespace Application.Purchase.Quiries.Bid.GetBidByorgcode
{
    public class GetBidOrgCodeQueryHandler : IRequestHandler<GetBidByorgcode, GetBidLoadorgcodeListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidOrgCodeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidLoadorgcodeListVm> Handle(GetBidByorgcode request, CancellationToken cancellationToken)
        {

            IList<BidOrg> Orgcode = await _procedureAdabter
               .Execute<BidOrg>("[Purchase].[proc_BidLoadByOrgCode]", request);
            GetBidLoadorgcodeListVm vm = new GetBidLoadorgcodeListVm
            {
                Orgcode = _mapper.Map<IList<BidOrg>, IList<GetBidLoadAllorgVm>>(Orgcode)
            };

            return vm;
        }
    }
}
