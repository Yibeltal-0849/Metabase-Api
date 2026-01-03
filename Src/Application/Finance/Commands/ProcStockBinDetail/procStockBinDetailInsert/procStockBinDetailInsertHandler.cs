using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStockBinDetailInsert.procStockBinDetailInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Stock_Bin_DetailInsert stored procedure.
	 
	 
      public class procStockBinDetailInsertHandler : IRequestHandler<procStockBinDetailInsertCommand, IList<StockBinDetail_Store_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStockBinDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StockBinDetail_Store_ID>> Handle( procStockBinDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<StockBinDetail_Store_ID> result = await _procedureAdabter
                .Execute<StockBinDetail_Store_ID>("[FINA].proc_Stock_Bin_DetailInsert", request);
           

            return result;
        }
    }
}
 
