



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.StockBIN.StockBINInsert.StockBINInsertCommand
{

    /// @author  Shimels Alem  Stock_BINInsert stored procedure.


    public class StockBINInsertHandler : IRequestHandler<StockBINInsertCommand, IList<Stock_BIN_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StockBINInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Stock_BIN_Store_ID>> Handle( StockBINInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Stock_BIN_Store_ID> result = await _procedureAdabter
                .Execute<Stock_BIN_Store_ID>("[Inventory].Stock_BINInsert", request);
           

            return result;
        }
    }
}
 