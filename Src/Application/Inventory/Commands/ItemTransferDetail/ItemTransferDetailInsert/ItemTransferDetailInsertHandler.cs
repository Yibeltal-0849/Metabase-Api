



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.ItemTransferDetail.ItemTransferDetailInsert.ItemTransferDetailInsertCommand
{

    /// @author  Shimels Alem  Item_Transfer_DetailInsert stored procedure.


    public class ItemTransferDetailInsertHandler : IRequestHandler<ItemTransferDetailInsertCommand, IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemTransferDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemTransferDetail_Transfer_Req_DetailID>> Handle( ItemTransferDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemTransferDetail_Transfer_Req_DetailID> result = await _procedureAdabter
                .Execute<ItemTransferDetail_Transfer_Req_DetailID>("[Inventory].Item_Transfer_DetailInsert", request);

            return result;
        }
    }
}
 