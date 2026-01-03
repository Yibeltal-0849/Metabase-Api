using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadAll
{
    class GetprocPurchaseLineLoadAllQueryHandler : IRequestHandler<GetprocPurchaseLineLoadAllQuery, GetprocPurchaseLineLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPurchaseLineLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPurchaseLineLoadAllListVm> Handle(GetprocPurchaseLineLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PurchaseLine> procPurchaseLines = await _procedureAdabter
               .Execute<PurchaseLine>("[FINA].[proc_Purchase_LineLoadAll]");
            GetprocPurchaseLineLoadAllListVm vm = new GetprocPurchaseLineLoadAllListVm
            {
                procPurchaseLines = _mapper.Map<IList<PurchaseLine>, IList<GetprocPurchaseLineLoadAllVm>>(procPurchaseLines)
            };

            return vm;
        }
    }
}
