



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.ItemReturnDetail.ItemReturnDetailInsert.ItemReturnDetailInsertCommand
{

    /// @author  Shimels Alem  Item_Return_DetailInsert stored procedure.


    public class ItemReturnDetailInsertHandler : IRequestHandler<ItemReturnDetailInsertCommand, IList<ItemReturnDetail_Request_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemReturnDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemReturnDetail_Request_DetailID>> Handle( ItemReturnDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemReturnDetail_Request_DetailID> result = await _procedureAdabter
                .Execute<ItemReturnDetail_Request_DetailID>("[Inventory].Item_Return_DetailInsert", request);
           

            return result;
        }
    }
}
 