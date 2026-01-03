using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPPurchasecreditmemo.GetprocPPurchasecreditmemoLoadAll
{
    class GetprocPPurchasecreditmemoLoadAllQueryHandler : IRequestHandler<GetprocPPurchasecreditmemoLoadAllQuery, GetprocPPurchasecreditmemoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPPurchasecreditmemoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPPurchasecreditmemoLoadAllListVm> Handle(GetprocPPurchasecreditmemoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PPurchaseCreditMemo> procPPurchasecreditmemos = await _procedureAdabter
               .Execute<PPurchaseCreditMemo>("[FINA].[proc_P_Purchase credit memoLoadAll]");
            GetprocPPurchasecreditmemoLoadAllListVm vm = new GetprocPPurchasecreditmemoLoadAllListVm
            {
                procPPurchasecreditmemos = _mapper.Map<IList<PPurchaseCreditMemo>, IList<GetprocPPurchasecreditmemoLoadAllVm>>(procPPurchasecreditmemos)
            };

            return vm;
        }
    }
}
