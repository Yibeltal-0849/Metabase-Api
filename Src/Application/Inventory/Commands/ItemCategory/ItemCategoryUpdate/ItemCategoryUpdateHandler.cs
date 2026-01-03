

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.ItemCategory.ItemCategoryUpdate.ItemCategoryUpdateCommand
{

    /// @author  Shimels Alem  Item_CategoryUpdate stored procedure.


    public class ItemCategoryUpdateHandler : IRequestHandler<ItemCategoryUpdateCommand, IList<Item_Category_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemCategoryUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Item_Category_Code>> Handle( ItemCategoryUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Item_Category_Code> result = await _procedureAdabter
                .Execute<Item_Category_Code>("[Inventory].Item_CategoryUpdate", request);
           

            return result;
        }
    }
}
 