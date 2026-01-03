using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemType.ItemTypeDelete.ItemTypeDeleteCommand
{

    /// @author  Shimels Alem  ItemTypeDelete stored procedure.


    public class ItemTypeDeleteHandler : IRequestHandler<ItemTypeDeleteCommand, IList<ItemType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemType_Name>> Handle( ItemTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ItemType_Name> result = await _procedureAdabter
                .Execute<ItemType_Name>("[Inventory].ItemTypeDelete", request);
           

            return result;
        }
    }
}
  