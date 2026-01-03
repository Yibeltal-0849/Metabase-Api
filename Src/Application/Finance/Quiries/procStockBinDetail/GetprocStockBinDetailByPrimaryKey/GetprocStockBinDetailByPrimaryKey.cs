using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procStockBinDetail.GetprocStockBinDetailLoadAll;

namespace Application.Finance.Quiries.procStockBinDetail.GetprocStockBinDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Stock_Bin_DetailLoadByPrimaryKey stored procedure.

    public class GetprocStockBinDetailByPrimaryKey : IRequest<GetprocStockBinDetailLoadAllListVm>
    {
        public System.DateTime Date { get; set; }
        public string ItemID { get; set; }
        public string Store_ID { get; set; }
    }
}
