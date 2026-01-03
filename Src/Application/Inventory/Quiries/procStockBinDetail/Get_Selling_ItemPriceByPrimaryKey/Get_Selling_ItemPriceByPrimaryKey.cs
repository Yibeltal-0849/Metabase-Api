using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procStockBinDetail.GetprocStockBinDetailLoadAll;

namespace Application.Inventory.Quiries.procStockBinDetail.Get_Selling_ItemPriceByPrimaryKey
{
    /// @author  Shimels Alem proc_Stock_Bin_DetailLoadByPrimaryKey stored procedure.

    public class Get_Selling_ItemPriceByPrimaryKey : IRequest<GetprocStockBinDetailLoadAllListVm>
    {
        public string ItemCode { get; set; }
       
    }
}
