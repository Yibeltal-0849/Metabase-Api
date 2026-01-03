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

namespace Application.Inventory.Quiries.InventoryItems.Getprocprice_calculator
{
    public class Getprocprice_calculatorQueryHandler : IRequestHandler<Getprocprice_calculator, GetInventoryItemspricelListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Getprocprice_calculatorQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetInventoryItemspricelListVm> Handle(Getprocprice_calculator request, CancellationToken cancellationToken)
        {
           
            IList<Inventory_Items> InventoryItemss = await _procedureAdabter
               .Execute<Inventory_Items>("[Inventory].[proc_Inventory_ItemsLoadByPrimaryKey]", request);
            GetInventoryItemspricelListVm vm = new GetInventoryItemspricelListVm
            {
                InventoryItemss = _mapper.Map<IList<Inventory_Items>, IList<GetInventoryItempriceVm>>(InventoryItemss)
            };

            return vm;
        }
    }
}
