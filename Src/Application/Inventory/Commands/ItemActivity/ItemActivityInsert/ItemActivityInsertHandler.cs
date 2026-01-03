using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemActivity.ItemActivityInsert
{
    public class ItemActivityInsertHandler : IRequestHandler<ItemActivityInsertCommand, IList<ItemActivity_Vocher_NO>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemActivityInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemActivity_Vocher_NO>> Handle(ItemActivityInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemActivity_Vocher_NO> result = await _procedureAdabter
                .Execute<ItemActivity_Vocher_NO>("[Inventory].Item_ActivityInsert", request);


            return result;
        }
    }
}
