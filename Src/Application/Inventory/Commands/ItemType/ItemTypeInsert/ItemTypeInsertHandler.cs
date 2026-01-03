



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.ItemType.ItemTypeInsert.ItemTypeInsertCommand
{

    /// @author  Shimels Alem  ItemTypeInsert stored procedure.


    public class ItemTypeInsertHandler : IRequestHandler<ItemTypeInsertCommand, IList<ItemType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemType_Name>> Handle( ItemTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemType_Name> result = await _procedureAdabter
                .Execute<ItemType_Name>("[Inventory].ItemTypeInsert", request);
           

            return result;
        }
    }
}
 