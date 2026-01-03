using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procStockBIN.GetprocStockBINLoadAll
{
    class GetprocStockBINLoadAllQueryHandler : IRequestHandler<GetprocStockBINLoadAllQuery, GetprocStockBINLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocStockBINLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStockBINLoadAllListVm> Handle(GetprocStockBINLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Stock_BIN> procStockBINs = await _procedureAdabter
               .Execute<Stock_BIN>("[Inventory].[proc_Stock_BINLoadAll]", request);
            GetprocStockBINLoadAllListVm vm = new GetprocStockBINLoadAllListVm
            {
                procStockBINs = _mapper.Map<IList<Stock_BIN>, IList<GetprocStockBINLoadAllVm>>(procStockBINs)
            };

            return vm;
        }
    }
}
