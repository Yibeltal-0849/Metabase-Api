



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cInventoryBeginingBalances.cInventoryBeginingBalancesInsert.cInventoryBeginingBalancesInsertCommand
{

    /// @author  Shimels Alem  c_Inventory_Begining_BalancesInsert stored procedure.


    public class cInventoryBeginingBalancesInsertHandler : IRequestHandler<cInventoryBeginingBalancesInsertCommand, IList<CInventoryBeginingBalances_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInventoryBeginingBalancesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInventoryBeginingBalances_Id>> Handle( cInventoryBeginingBalancesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CInventoryBeginingBalances_Id> result = await _procedureAdabter
                .Execute<CInventoryBeginingBalances_Id>("[FINA].c_Inventory_Begining_BalancesInsert", request);
           
            return result;
        }
    }
}
 