using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procPPurchasecreditmemo
{
    public class GetprocPPurchasecreditmemoLoadAllVm : IMapFrom<PPurchaseCreditMemo>
    {
        public System.Guid Purchase_Line { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public string Job_Line_Type { get; set; }
        public string Job_Task_No { get; set; }
        public double? Job_Unit_Price { get; set; }
        public double? Job_Total_Price { get; set; }
        public double? Job_Line_Amount { get; set; }
        public double? Job_Line_Discount_Amount { get; set; }
        public double? Job_Line_Discount_Per { get; set; }
        public double? Job_Unit_Price_LCY { get; set; }
        public double? Job_Total_Price_LCY { get; set; }
        public double? Job_Line_Amount_LCY { get; set; }
        public double? Job_Line_Disc_Amount_LCY { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PPurchaseCreditMemo, GetprocPPurchasecreditmemoLoadAllVm>();
        }
    }
}
