using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.StoreItemActivityType.StoreItemActivityTypeDelete.StoreItemActivityTypeDeleteCommand
{

    /// @author  Shimels Alem  Store_Item_Activity_TypeDelete stored procedure.


    public class StoreItemActivityTypeDeleteHandler : IRequestHandler<StoreItemActivityTypeDeleteCommand, IList<Store_Item_Activity_Type_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StoreItemActivityTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Store_Item_Activity_Type_Code>> Handle( StoreItemActivityTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Store_Item_Activity_Type_Code> result = await _procedureAdabter
                .Execute<Store_Item_Activity_Type_Code>("[Inventory].Store_Item_Activity_TypeDelete", request);
           

            return result;
        }
    }
}
  