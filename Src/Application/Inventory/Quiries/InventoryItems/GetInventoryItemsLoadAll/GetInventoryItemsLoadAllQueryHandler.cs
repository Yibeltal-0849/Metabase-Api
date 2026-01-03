using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll
{
    class GetInventoryItemsLoadAllQueryHandler : IRequestHandler<GetInventoryItemsLoadAllQuery, GetInventoryItemsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetInventoryItemsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetInventoryItemsLoadAllListVm> Handle(GetInventoryItemsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Inventory_Items> InventoryItemss = await _procedureAdabter
               .Execute<Inventory_Items>("[Inventory].[proc_Inventory_ItemsLoadAll]");
            GetInventoryItemsLoadAllListVm vm = new GetInventoryItemsLoadAllListVm
            {
                InventoryItemss = _mapper.Map<IList<Inventory_Items>, IList<GetInventoryItemsLoadAllVm>>(InventoryItemss)
            };

            return vm;
        }
    }
}
