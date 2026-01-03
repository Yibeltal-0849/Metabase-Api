using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.procInventoryPostingGroup.procInventoryPostingGroupDelete.procInventoryPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  proc_Inventory_Posting_GroupDelete stored procedure.


    public class procInventoryPostingGroupDeleteHandler : IRequestHandler<procInventoryPostingGroupDeleteCommand, IList<InventoryPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInventoryPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingGroup_Code>> Handle( procInventoryPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingGroup_Code> result = await _procedureAdabter
                .Execute<InventoryPostingGroup_Code>("[Inventory].proc_Inventory_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  