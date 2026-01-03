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


	public class InventoryItemsUpdateCommand : IRequest<IList<Inventory_Items_Inv_ID>>
   {
        public string Inv_ID { get; set; }
        public string Item_Name { get; set; }
        public string Description { get; set; }
        public string Item_Class { get; set; }
        public string Item_Category_code { get; set; }
        public decimal? Price { get; set; }
        public string Cost_Method { get; set; }
        public string OrgCode { get; set; }
        public decimal? Last_Unit_Cost { get; set; }
        public string UPC_SKU { get; set; }
        public string PartNumber { get; set; }
        public string Stocking_Unit { get; set; }
        public decimal? Weight { get; set; }
        public string Shelf_No { get; set; }
        public string Item_Tax_Type { get; set; }
        public long? Minimum_Stock { get; set; }
        public long? Reorder_Quantity { get; set; }
        public string Referred_Vendor_id { get; set; }
        public string Gen_Pord_Posting_Group { get; set; }
        public string Inventory_Posting_Group { get; set; }
        public byte[] Picture { get; set; }
        public string Buyer_ID { get; set; }
        public string Json_Meta_Data { get; set; }
        public string Json_Data { get; set; }
        public double Proft { get; set; }


    }



}

