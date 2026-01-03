using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSalesLines.GetprocSalesLinesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSalesLines.GetprocSalesLinesByPrimaryKey
{
    public class GetprocSalesLinesQueryHandler : IRequestHandler<GetprocSalesLinesByPrimaryKey, GetprocSalesLinesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSalesLinesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSalesLinesLoadAllListVm> Handle(GetprocSalesLinesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Sales_Lines> procSalesLiness = await _procedureAdabter
               .Execute<Sales_Lines>("[FINA].[proc_Sales_LinesLoadByPrimaryKey]", request);
            GetprocSalesLinesLoadAllListVm vm = new GetprocSalesLinesLoadAllListVm
            {
                procSalesLiness = _mapper.Map<IList<Sales_Lines>, IList<GetprocSalesLinesLoadAllVm>>(procSalesLiness)
            };

            return vm;
        }
    }
}
