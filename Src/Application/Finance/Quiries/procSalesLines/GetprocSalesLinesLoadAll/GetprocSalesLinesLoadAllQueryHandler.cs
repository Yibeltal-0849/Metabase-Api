using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSalesLines.GetprocSalesLinesLoadAll
{
    class GetprocSalesLinesLoadAllQueryHandler : IRequestHandler<GetprocSalesLinesLoadAllQuery, GetprocSalesLinesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSalesLinesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSalesLinesLoadAllListVm> Handle(GetprocSalesLinesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Sales_Lines> procSalesLiness = await _procedureAdabter
               .Execute<Sales_Lines>("[FINA].[proc_Sales_LinesLoadAll]");
            GetprocSalesLinesLoadAllListVm vm = new GetprocSalesLinesLoadAllListVm
            {
                procSalesLiness = _mapper.Map<IList<Sales_Lines>, IList<GetprocSalesLinesLoadAllVm>>(procSalesLiness)
            };

            return vm;
        }
    }
}
