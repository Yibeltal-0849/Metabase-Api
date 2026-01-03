using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procStockBinDetail.GetprocStockBinDetailLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procStockBinDetail.Get_Selling_ItemPriceByPrimaryKey
{
    public class Get_Selling_ItemPriceQueryHandler : IRequestHandler<Get_Selling_ItemPriceByPrimaryKey, GetprocStockBinDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Get_Selling_ItemPriceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStockBinDetailLoadAllListVm> Handle(Get_Selling_ItemPriceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<StockBinDetail> procStockBinDetails = await _procedureAdabter
               .Execute<StockBinDetail>("FINA.[Get_Selling_ItemPrice]", request);
            GetprocStockBinDetailLoadAllListVm vm = new GetprocStockBinDetailLoadAllListVm
            {
                procStockBinDetails = _mapper.Map<IList<StockBinDetail>, IList<GetprocStockBinDetailLoadAllVm>>(procStockBinDetails)
            };

            return vm;
        }
    }
}
