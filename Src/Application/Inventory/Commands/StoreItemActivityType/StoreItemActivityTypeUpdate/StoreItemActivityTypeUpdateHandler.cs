

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.StoreItemActivityType.StoreItemActivityTypeUpdate.StoreItemActivityTypeUpdateCommand
{

    /// @author  Shimels Alem  Store_Item_Activity_TypeUpdate stored procedure.


    public class StoreItemActivityTypeUpdateHandler : IRequestHandler<StoreItemActivityTypeUpdateCommand, IList<Store_Item_Activity_Type_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StoreItemActivityTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Store_Item_Activity_Type_Code>> Handle( StoreItemActivityTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Store_Item_Activity_Type_Code> result = await _procedureAdabter
                .Execute<Store_Item_Activity_Type_Code>("[Inventory].Store_Item_Activity_TypeUpdate", request);
          
            return result;
        }
    }
}
 