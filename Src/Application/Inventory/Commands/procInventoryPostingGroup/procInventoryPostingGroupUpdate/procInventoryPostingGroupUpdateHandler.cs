

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.procInventoryPostingGroup.procInventoryPostingGroupUpdate.procInventoryPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  proc_Inventory_Posting_GroupUpdate stored procedure.


    public class procInventoryPostingGroupUpdateHandler : IRequestHandler<procInventoryPostingGroupUpdateCommand, IList<InventoryPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInventoryPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingGroup_Code>> Handle( procInventoryPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingGroup_Code> result = await _procedureAdabter
                .Execute<InventoryPostingGroup_Code>("[Inventory].proc_Inventory_Posting_GroupUpdate", request);

            return result;
        }
    }
}
 