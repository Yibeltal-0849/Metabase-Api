



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.InventoryPostingGroup.InventoryPostingGroupInsert.InventoryPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Inventory_Posting_GroupInsert stored procedure.


    public class InventoryPostingGroupInsertHandler : IRequestHandler<InventoryPostingGroupInsertCommand, IList<InventoryPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<InventoryPostingGroup_Code>> Handle( InventoryPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<InventoryPostingGroup_Code> result = await _procedureAdabter
                .Execute<InventoryPostingGroup_Code>("[FINA].Inventory_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 