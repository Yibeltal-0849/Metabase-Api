



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.procInventoryPostingGroup.procInventoryPostingGroupInsert.procInventoryPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_Inventory_Posting_GroupInsert stored procedure.


    public class procInventoryPostingGroupInsertHandler : IRequestHandler<procInventoryPostingGroupInsertCommand, IList<InventoryPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInventoryPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingGroup_Code>> Handle( procInventoryPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingGroup_Code> result = await _procedureAdabter
                .Execute<InventoryPostingGroup_Code>("[Inventory].proc_Inventory_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 