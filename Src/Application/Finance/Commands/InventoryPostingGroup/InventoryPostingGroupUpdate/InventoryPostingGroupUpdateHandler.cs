

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.InventoryPostingGroup.InventoryPostingGroupUpdate.InventoryPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  Inventory_Posting_GroupUpdate stored procedure.


    public class InventoryPostingGroupUpdateHandler : IRequestHandler<InventoryPostingGroupUpdateCommand, IList<InventoryPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingGroup_Code>> Handle( InventoryPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingGroup_Code> result = await _procedureAdabter
                .Execute<InventoryPostingGroup_Code>("[FINA].Inventory_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 