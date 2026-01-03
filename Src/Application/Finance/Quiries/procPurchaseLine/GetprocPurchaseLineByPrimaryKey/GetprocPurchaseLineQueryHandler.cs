using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineByPrimaryKey
{
    public class GetprocPurchaseLineQueryHandler : IRequestHandler<GetprocPurchaseLineByPrimaryKey, GetprocPurchaseLineLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPurchaseLineQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPurchaseLineLoadAllListVm> Handle(GetprocPurchaseLineByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PurchaseLine> procPurchaseLines = await _procedureAdabter
               .Execute<PurchaseLine>("[FINA].[proc_Purchase_LineLoadByPrimaryKey]", request);
            GetprocPurchaseLineLoadAllListVm vm = new GetprocPurchaseLineLoadAllListVm
            {
                procPurchaseLines = _mapper.Map<IList<PurchaseLine>, IList<GetprocPurchaseLineLoadAllVm>>(procPurchaseLines)
            };

            return vm;
        }
    }
}
