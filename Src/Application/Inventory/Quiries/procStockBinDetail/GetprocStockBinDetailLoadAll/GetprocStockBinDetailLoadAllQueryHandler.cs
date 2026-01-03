using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procStockBinDetail.GetprocStockBinDetailLoadAll
{
    class GetprocStockBinDetailLoadAllQueryHandler : IRequestHandler<GetprocStockBinDetailLoadAllQuery, GetprocStockBinDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocStockBinDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStockBinDetailLoadAllListVm> Handle(GetprocStockBinDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<StockBinDetail> procStockBinDetails = await _procedureAdabter
               .Execute<StockBinDetail>("[Inventory].[proc_Stock_Bin_DetailLoadAll]");
            GetprocStockBinDetailLoadAllListVm vm = new GetprocStockBinDetailLoadAllListVm
            {
                procStockBinDetails = _mapper.Map<IList<StockBinDetail>, IList<GetprocStockBinDetailLoadAllVm>>(procStockBinDetails)
            };

            return vm;
        }
    }
}
