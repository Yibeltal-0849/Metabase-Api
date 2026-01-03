using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPPurchasereturnorder.GetprocPPurchasereturnorderLoadAll
{
    class GetprocPPurchasereturnorderLoadAllQueryHandler : IRequestHandler<GetprocPPurchasereturnorderLoadAllQuery, GetprocPPurchasereturnorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPPurchasereturnorderLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPPurchasereturnorderLoadAllListVm> Handle(GetprocPPurchasereturnorderLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PPurchaseReturnOrder> procPPurchasereturnorders = await _procedureAdabter
               .Execute<PPurchaseReturnOrder>("[FINA].[proc_P_Purchase return orderLoadAll]");
            GetprocPPurchasereturnorderLoadAllListVm vm = new GetprocPPurchasereturnorderLoadAllListVm
            {
                procPPurchasereturnorders = _mapper.Map<IList<PPurchaseReturnOrder>, IList<GetprocPPurchasereturnorderLoadAllVm>>(procPPurchasereturnorders)
            };

            return vm;
        }
    }
}
