



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.cItems.cItemsInsert.cItemsInsertCommand
{

    /// @author  Shimels Alem  c_ItemsInsert stored procedure.


    public class cItemsInsertHandler : IRequestHandler<cItemsInsertCommand, IList<C_Items_Item_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<C_Items_Item_Id>> Handle( cItemsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<C_Items_Item_Id> result = await _procedureAdabter
                .Execute<C_Items_Item_Id>("[Inventory].c_ItemsInsert", request);
           

            return result;
        }
    }
}
 