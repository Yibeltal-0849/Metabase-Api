using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.StockBinDetail.StockBinDetailDelete.StockBinDetailDeleteCommand
{

    /// @author  Shimels Alem  Stock_Bin_DetailDelete stored procedure.


    public class StockBinDetailDeleteHandler : IRequestHandler<StockBinDetailDeleteCommand, IList<StockBinDetail_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StockBinDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StockBinDetail_Store_ID>> Handle( StockBinDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<StockBinDetail_Store_ID> result = await _procedureAdabter
                .Execute<StockBinDetail_Store_ID>("[Inventory].Stock_Bin_DetailDelete", request);
           
            return result;
        }
    }
}
  