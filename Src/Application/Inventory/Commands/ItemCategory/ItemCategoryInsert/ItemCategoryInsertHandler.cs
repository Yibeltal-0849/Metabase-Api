



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.ItemCategory.ItemCategoryInsert.ItemCategoryInsertCommand
{

    /// @author  Shimels Alem  Item_CategoryInsert stored procedure.


    public class ItemCategoryInsertHandler : IRequestHandler<ItemCategoryInsertCommand, IList<Item_Category_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemCategoryInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Item_Category_Code>> Handle( ItemCategoryInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Item_Category_Code> result = await _procedureAdabter
                .Execute<Item_Category_Code>("[Inventory].Item_CategoryInsert", request);
           

            return result;
        }
    }
}
 