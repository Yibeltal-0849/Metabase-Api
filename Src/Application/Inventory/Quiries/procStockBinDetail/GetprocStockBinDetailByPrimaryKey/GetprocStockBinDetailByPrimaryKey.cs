using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procStockBinDetail.GetprocStockBinDetailLoadAll;

namespace Application.Inventory.Quiries.procStockBinDetail.GetprocStockBinDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Stock_Bin_DetailLoadByPrimaryKey stored procedure.

    public class GetprocStockBinDetailByPrimaryKey : IRequest<GetprocStockBinDetailLoadAllListVm>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
       // public System.DateTime Date { get; set; }
    }
}
