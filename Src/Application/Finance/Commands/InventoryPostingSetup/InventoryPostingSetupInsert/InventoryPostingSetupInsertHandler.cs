



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.InventoryPostingSetup.InventoryPostingSetupInsert.InventoryPostingSetupInsertCommand
{

    /// @author  Shimels Alem  Inventory_Posting_SetupInsert stored procedure.


    public class InventoryPostingSetupInsertHandler : IRequestHandler<InventoryPostingSetupInsertCommand, IList<InventoryPostingSetup_Store_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryPostingSetupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingSetup_Store_Code>> Handle( InventoryPostingSetupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingSetup_Store_Code> result = await _procedureAdabter
                .Execute<InventoryPostingSetup_Store_Code>("[FINA].Inventory_Posting_SetupInsert", request);
           

            return result;
        }
    }
}
 