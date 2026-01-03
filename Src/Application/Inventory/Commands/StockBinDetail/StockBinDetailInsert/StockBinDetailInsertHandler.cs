



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.StockBinDetail.StockBinDetailInsert.StockBinDetailInsertCommand
{

    /// @author  Shimels Alem  Stock_Bin_DetailInsert stored procedure.


    public class StockBinDetailInsertHandler : IRequestHandler<StockBinDetailInsertCommand, IList<StockBinDetail_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StockBinDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StockBinDetail_Store_ID>> Handle( StockBinDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<StockBinDetail_Store_ID> result = await _procedureAdabter
                .Execute<StockBinDetail_Store_ID>("[Inventory].Stock_Bin_DetailInsert", request);
           

            return result;
        }
    }
}
 