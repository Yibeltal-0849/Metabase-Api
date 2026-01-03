using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.InventoryItems.GetInventoryItemsByPrimaryKey
{
    public class GetInventoryItemsQueryHandler : IRequestHandler<GetInventoryItemsByPrimaryKey, GetInventoryItemsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetInventoryItemsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetInventoryItemsLoadAllListVm> Handle(GetInventoryItemsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Inventory_Items> InventoryItemss = await _procedureAdabter
               .Execute<Inventory_Items>("[Inventory].[proc_Inventory_ItemsLoadByPrimaryKey]", request);
            GetInventoryItemsLoadAllListVm vm = new GetInventoryItemsLoadAllListVm
            {
                InventoryItemss = _mapper.Map<IList<Inventory_Items>, IList<GetInventoryItemsLoadAllVm>>(InventoryItemss)
            };

            return vm;
        }
    }
}
