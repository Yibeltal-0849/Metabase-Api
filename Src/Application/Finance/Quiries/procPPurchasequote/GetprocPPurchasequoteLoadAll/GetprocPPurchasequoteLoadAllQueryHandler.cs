using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPPurchasequote.GetprocPPurchasequoteLoadAll
{
    class GetprocPPurchasequoteLoadAllQueryHandler : IRequestHandler<GetprocPPurchasequoteLoadAllQuery, GetprocPPurchasequoteLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPPurchasequoteLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPPurchasequoteLoadAllListVm> Handle(GetprocPPurchasequoteLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PPurchaseQuote> procPPurchasequotes = await _procedureAdabter
               .Execute<PPurchaseQuote>("[FINA].[proc_P_Purchase quoteLoadAll]");
            GetprocPPurchasequoteLoadAllListVm vm = new GetprocPPurchasequoteLoadAllListVm
            {
                procPPurchasequotes = _mapper.Map<IList<PPurchaseQuote>, IList<GetprocPPurchasequoteLoadAllVm>>(procPPurchasequotes)
            };

            return vm;
        }
    }
}
