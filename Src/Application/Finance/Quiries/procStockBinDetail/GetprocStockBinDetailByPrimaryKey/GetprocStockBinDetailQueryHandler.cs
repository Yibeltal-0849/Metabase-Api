using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procStockBinDetail.GetprocStockBinDetailLoadAll;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Quiries.procStockBinDetail.GetprocStockBinDetailByPrimaryKey
{
    public class GetprocStockBinDetailQueryHandler : IRequestHandler<GetprocStockBinDetailByPrimaryKey, GetprocStockBinDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocStockBinDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStockBinDetailLoadAllListVm> Handle(GetprocStockBinDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<StockBinDetail> procStockBinDetails = await _procedureAdabter
               .Execute<StockBinDetail>("[FINA].[proc_Stock_Bin_DetailLoadByPrimaryKey]", request);
            GetprocStockBinDetailLoadAllListVm vm = new GetprocStockBinDetailLoadAllListVm
            {
                procStockBinDetails = _mapper.Map<IList<StockBinDetail>, IList<GetprocStockBinDetailLoadAllVm>>(procStockBinDetails)
            };

            return vm;
        }
    }
}
