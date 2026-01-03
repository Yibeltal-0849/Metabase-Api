using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJ_Phys_Inventory_Journal
{
    public class GetprocJ_Phys_Inventory_JournalLoadAllVm : IMapFrom<J_Phys_Inventory_Journal>
    {
        public System.DateTime Posting_Date { get; set; }
        public string Entry_Type { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        public string Description { get; set; }
        public string Location_Code { get; set; }
        public Nullable<double> Qty_Calculated { get; set; }
        public Nullable<double> Qty_Phys_Inventory { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Amount_Birr { get; set; }
        public Nullable<double> Unit_Cost_Birr { get; set; }
        public Nullable<long> Last_Item_Ledger_Entry_No { get; set; }
        public long Entry_No { get; set; }
        public Guid Brnach_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<J_Phys_Inventory_Journal, GetprocJ_Phys_Inventory_JournalLoadAllVm>();
        }
    }
}
