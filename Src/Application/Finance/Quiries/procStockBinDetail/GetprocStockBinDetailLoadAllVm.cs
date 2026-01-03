using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Quiries.procStockBinDetail
{
    public class GetprocStockBinDetailLoadAllVm : IMapFrom<StockBinDetail>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
        public System.DateTime Date { get; set; }
        public string Vocher_No { get; set; }
        public double? In_QTY { get; set; }
        public double? IN_Unit_Price { get; set; }
        public double? IN_Total_Price { get; set; }
        public double? Bal_QTY { get; set; }
        public double? Bal_Unit_Price { get; set; }
        public double? Bal_Total_Price { get; set; }
        public double? Adjustment { get; set; }
        public bool? POST_To_Account { get; set; }
        public double? Remark { get; set; }
        public string Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<StockBinDetail, GetprocStockBinDetailLoadAllVm>();
        }
    }
}
