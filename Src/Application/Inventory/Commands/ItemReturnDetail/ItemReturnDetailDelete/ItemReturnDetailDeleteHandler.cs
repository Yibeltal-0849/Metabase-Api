using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemReturnDetail.ItemReturnDetailDelete.ItemReturnDetailDeleteCommand
{

    /// @author  Shimels Alem  Item_Return_DetailDelete stored procedure.


    public class ItemReturnDetailDeleteHandler : IRequestHandler<ItemReturnDetailDeleteCommand, IList<ItemReturnDetail_Request_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemReturnDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemReturnDetail_Request_DetailID>> Handle( ItemReturnDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ItemReturnDetail_Request_DetailID> result = await _procedureAdabter
                .Execute<ItemReturnDetail_Request_DetailID>("[Inventory].Item_Return_DetailDelete", request);
           
            return result;
        }
    }
}
  