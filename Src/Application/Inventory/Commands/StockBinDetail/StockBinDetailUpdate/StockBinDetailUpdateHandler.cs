

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.StockBinDetail.StockBinDetailUpdate.StockBinDetailUpdateCommand
{

    /// @author  Shimels Alem  Stock_Bin_DetailUpdate stored procedure.


    public class StockBinDetailUpdateHandler : IRequestHandler<StockBinDetailUpdateCommand, IList<StockBinDetail_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StockBinDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StockBinDetail_Store_ID>> Handle( StockBinDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<StockBinDetail_Store_ID> result = await _procedureAdabter
                .Execute<StockBinDetail_Store_ID>("[Inventory].Stock_Bin_DetailUpdate", request);
           
            return result;
        }
    }
}
 