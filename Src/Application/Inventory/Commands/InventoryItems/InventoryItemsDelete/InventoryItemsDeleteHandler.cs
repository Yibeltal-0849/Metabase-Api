using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.InventoryItems.InventoryItemsDelete.InventoryItemsDeleteCommand
{

    /// @author  Shimels Alem  Inventory_ItemsDelete stored procedure.


    public class InventoryItemsDeleteHandler : IRequestHandler<InventoryItemsDeleteCommand, IList<Inventory_Items_Inv_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryItemsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Inventory_Items_Inv_ID>> Handle( InventoryItemsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Inventory_Items_Inv_ID> result = await _procedureAdabter
                .Execute<Inventory_Items_Inv_ID>("[Inventory].Inventory_ItemsDelete", request);
           
            return result;
        }
    }
}
  