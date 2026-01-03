

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.ItemType.ItemTypeUpdate.ItemTypeUpdateCommand
{

    /// @author  Shimels Alem  ItemTypeUpdate stored procedure.


    public class ItemTypeUpdateHandler : IRequestHandler<ItemTypeUpdateCommand, IList<ItemType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemType_Name>> Handle( ItemTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ItemType_Name> result = await _procedureAdabter
                .Execute<ItemType_Name>("[Inventory].ItemTypeUpdate", request);
           

            return result;
        }
    }
}
 