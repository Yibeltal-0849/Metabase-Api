using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.InventoryPostingSetup.InventoryPostingSetupDelete.InventoryPostingSetupDeleteCommand
{

    /// @author  Shimels Alem  Inventory_Posting_SetupDelete stored procedure.


    public class InventoryPostingSetupDeleteHandler : IRequestHandler<InventoryPostingSetupDeleteCommand, IList<InventoryPostingSetup_Store_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryPostingSetupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingSetup_Store_Code>> Handle( InventoryPostingSetupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingSetup_Store_Code> result = await _procedureAdabter
                .Execute<InventoryPostingSetup_Store_Code>("[FINA].Inventory_Posting_SetupDelete", request);
           

            return result;
        }
    }
}
  