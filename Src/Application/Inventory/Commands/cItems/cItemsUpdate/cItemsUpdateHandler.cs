

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.cItems.cItemsUpdate.cItemsUpdateCommand
{

    /// @author  Shimels Alem  c_ItemsUpdate stored procedure.


    public class cItemsUpdateHandler : IRequestHandler<cItemsUpdateCommand, IList<C_Items_Item_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<C_Items_Item_Id>> Handle( cItemsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<C_Items_Item_Id> result = await _procedureAdabter
                .Execute<C_Items_Item_Id>("[Inventory].c_ItemsUpdate", request);
           

            return result;
        }
    }
}
 