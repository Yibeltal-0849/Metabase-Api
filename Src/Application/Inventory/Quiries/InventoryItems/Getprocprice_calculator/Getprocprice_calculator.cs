using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;

namespace Application.Inventory.Quiries.InventoryItems.Getprocprice_calculator
{
    public class Getprocprice_calculator : IRequest<GetInventoryItemspricelListVm>
    {
        public string Inv_ID { get; set; }

    }
}
