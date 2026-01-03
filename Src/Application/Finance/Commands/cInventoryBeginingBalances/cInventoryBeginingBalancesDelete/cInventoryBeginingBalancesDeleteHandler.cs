using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cInventoryBeginingBalances.cInventoryBeginingBalancesDelete.cInventoryBeginingBalancesDeleteCommand
{

    /// @author  Shimels Alem  c_Inventory_Begining_BalancesDelete stored procedure.


    public class cInventoryBeginingBalancesDeleteHandler : IRequestHandler<cInventoryBeginingBalancesDeleteCommand, IList<CInventoryBeginingBalances_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInventoryBeginingBalancesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInventoryBeginingBalances_Id>> Handle( cInventoryBeginingBalancesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CInventoryBeginingBalances_Id> result = await _procedureAdabter
                .Execute<CInventoryBeginingBalances_Id>("[FINA].c_Inventory_Begining_BalancesDelete", request);
           

            return result;
        }
    }
}
  