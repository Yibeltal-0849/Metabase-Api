using System;

namespace XOKA.Domain.Entities.Finance
{
    public class J_Phys_Inventory_Journal
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
    }
}
