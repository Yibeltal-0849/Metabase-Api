using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemCategory.ItemCategoryDelete.ItemCategoryDeleteCommand
{

    /// @author  Shimels Alem  Item_CategoryDelete stored procedure.


    public class ItemCategoryDeleteHandler : IRequestHandler<ItemCategoryDeleteCommand, IList<Item_Category_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemCategoryDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Item_Category_Code>> Handle( ItemCategoryDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Item_Category_Code> result = await _procedureAdabter
                .Execute<Item_Category_Code>("[Inventory].Item_CategoryDelete", request);
           

            return result;
        }
    }
}
  