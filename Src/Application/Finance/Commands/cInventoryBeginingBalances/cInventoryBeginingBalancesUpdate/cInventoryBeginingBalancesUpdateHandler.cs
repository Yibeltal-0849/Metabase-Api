

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cInventoryBeginingBalances.cInventoryBeginingBalancesUpdate.cInventoryBeginingBalancesUpdateCommand
{

    /// @author  Shimels Alem  c_Inventory_Begining_BalancesUpdate stored procedure.


    public class cInventoryBeginingBalancesUpdateHandler : IRequestHandler<cInventoryBeginingBalancesUpdateCommand, IList<CInventoryBeginingBalances_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInventoryBeginingBalancesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInventoryBeginingBalances_Id>> Handle( cInventoryBeginingBalancesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CInventoryBeginingBalances_Id> result = await _procedureAdabter
                .Execute<CInventoryBeginingBalances_Id>("[FINA].c_Inventory_Begining_BalancesUpdate", request);
           

            return result;
        }
    }
}
 