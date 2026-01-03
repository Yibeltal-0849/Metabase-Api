using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.StockBIN.StockBINDelete.StockBINDeleteCommand
{

    /// @author  Shimels Alem  Stock_BINDelete stored procedure.


    public class StockBINDeleteHandler : IRequestHandler<StockBINDeleteCommand, IList<Stock_BIN_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StockBINDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Stock_BIN_Store_ID>> Handle( StockBINDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Stock_BIN_Store_ID> result = await _procedureAdabter
                .Execute<Stock_BIN_Store_ID>("[Inventory].Stock_BINDelete", request);
           

            return result;
        }
    }
}
  