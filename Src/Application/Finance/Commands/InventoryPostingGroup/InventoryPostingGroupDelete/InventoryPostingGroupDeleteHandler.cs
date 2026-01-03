using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.InventoryPostingGroup.InventoryPostingGroupDelete.InventoryPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  Inventory_Posting_GroupDelete stored procedure.


    public class InventoryPostingGroupDeleteHandler : IRequestHandler<InventoryPostingGroupDeleteCommand, IList<InventoryPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingGroup_Code>> Handle( InventoryPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingGroup_Code> result = await _procedureAdabter
                .Execute<InventoryPostingGroup_Code>("[FINA].Inventory_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  