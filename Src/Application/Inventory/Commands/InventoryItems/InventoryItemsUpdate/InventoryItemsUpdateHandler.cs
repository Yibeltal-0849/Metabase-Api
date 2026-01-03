

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.InventoryItems.InventoryItemsUpdate.InventoryItemsUpdateCommand
{

    /// @author  Shimels Alem  Inventory_ItemsUpdate stored procedure.


    public class InventoryItemsUpdateHandler : IRequestHandler<InventoryItemsUpdateCommand, IList<Inventory_Items_Inv_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public InventoryItemsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Inventory_Items_Inv_ID>> Handle( InventoryItemsUpdateCommand request, CancellationToken cancellationToken)
        {
            string Inv_ID = request.Inv_ID;
            string Item_Name = request.Item_Name;
            string Description = request.Description;
            string Item_Class = request.Item_Class;
            decimal? Price = request.Price;
            string Cost_Method = request.Cost_Method;
            string OrgCode = request.OrgCode;
            decimal? Last_Unit_Cost = request.Last_Unit_Cost;
            string UPC_SKU = request.UPC_SKU;
            string PartNumber = request.PartNumber;
            string Stocking_Unit = request.Stocking_Unit;
            decimal? Weight = request.Weight;
            string Shelf_No = request.Shelf_No;
            string Item_Tax_Type = request.Item_Tax_Type;
            long? Minimum_Stock = request.Minimum_Stock;
            long? Reorder_Quantity = request.Reorder_Quantity;
            string Referred_Vendor_id = request.Referred_Vendor_id;
            string Gen_Pord_Posting_Group = request.Gen_Pord_Posting_Group;
            string Inventory_Posting_Group = request.Inventory_Posting_Group;
            byte[] Picture = request.Picture;
            string Buyer_ID = request.Buyer_ID;
            string Json_Meta_Data = request.Json_Meta_Data;
            string Json_Data = request.Json_Data;
            double Proft = request.Proft;

            IList<Inventory_Items_Inv_ID> result = await _procedureAdabter
                .Execute<Inventory_Items_Inv_ID>("[Inventory].Inventory_ItemsUpdate",
                 (nameof(Inv_ID), Inv_ID),
                 (nameof(Item_Name), Item_Name),
                 (nameof(Description), Description),
                 (nameof(Item_Class), Item_Class),
                 (nameof(Price), Price),
                 (nameof(Cost_Method), Cost_Method),
                 (nameof(OrgCode), OrgCode),
                 (nameof(Last_Unit_Cost), Last_Unit_Cost),
                 (nameof(UPC_SKU), UPC_SKU),
                 (nameof(PartNumber), PartNumber),
                 (nameof(Stocking_Unit), Stocking_Unit),
                 (nameof(Weight), Weight),
                 (nameof(Shelf_No), Shelf_No),
                 (nameof(Item_Tax_Type), Item_Tax_Type),
                 (nameof(Minimum_Stock), Minimum_Stock),
                 (nameof(Reorder_Quantity), Reorder_Quantity),
                 (nameof(Referred_Vendor_id), Referred_Vendor_id),
                 (nameof(Gen_Pord_Posting_Group), Gen_Pord_Posting_Group),
                 (nameof(Inventory_Posting_Group), Inventory_Posting_Group),
                 (nameof(Picture), Picture),
                 (nameof(Buyer_ID), Buyer_ID),
                 (nameof(Json_Meta_Data), Json_Meta_Data),
                 (nameof(Json_Data), Json_Data),
                 (nameof(Proft), Proft)
                );


            return result;
        }
    }
}
 