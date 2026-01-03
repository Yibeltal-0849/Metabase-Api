using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStockBinDetailUpdate.procStockBinDetailUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Stock_Bin_DetailUpdate stored procedure.
	 
	 
      public class procStockBinDetailUpdateHandler : IRequestHandler<procStockBinDetailUpdateCommand, IList<StockBinDetail_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStockBinDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StockBinDetail_Store_ID>> Handle( procStockBinDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<StockBinDetail_Store_ID> result = await _procedureAdabter
                .Execute<StockBinDetail_Store_ID>("[FINA].proc_Stock_Bin_DetailUpdate", request);
           

            return result;
        }
    }
}
 
