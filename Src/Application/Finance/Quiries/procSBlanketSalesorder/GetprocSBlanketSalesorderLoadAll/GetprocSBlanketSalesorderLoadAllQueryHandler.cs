using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSBlanketSalesorder.GetprocSBlanketSalesorderLoadAll
{
    class GetprocSBlanketSalesorderLoadAllQueryHandler : IRequestHandler<GetprocSBlanketSalesorderLoadAllQuery, GetprocSBlanketSalesorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSBlanketSalesorderLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSBlanketSalesorderLoadAllListVm> Handle(GetprocSBlanketSalesorderLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SBlanketSalesOrder> procSBlanketSalesorders = await _procedureAdabter
               .Execute<SBlanketSalesOrder>("[FINA].[proc_S_Blanket_Sales_orderLoadAll]");
            GetprocSBlanketSalesorderLoadAllListVm vm = new GetprocSBlanketSalesorderLoadAllListVm
            {
                procSBlanketSalesorders = _mapper.Map<IList<SBlanketSalesOrder>, IList<GetprocSBlanketSalesorderLoadAllVm>>(procSBlanketSalesorders)
            };

            return vm;
        }
    }
}
