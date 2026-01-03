

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.InventoryPostingSetup.InventoryPostingSetupUpdate.InventoryPostingSetupUpdateCommand
{

    /// @author  Shimels Alem  Inventory_Posting_SetupUpdate stored procedure.


    public class InventoryPostingSetupUpdateHandler : IRequestHandler<InventoryPostingSetupUpdateCommand, IList<InventoryPostingSetup_Store_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryPostingSetupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingSetup_Store_Code>> Handle( InventoryPostingSetupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingSetup_Store_Code> result = await _procedureAdabter
                .Execute<InventoryPostingSetup_Store_Code>("[FINA].Inventory_Posting_SetupUpdate", request);
           

            return result;
        }
    }
}
 