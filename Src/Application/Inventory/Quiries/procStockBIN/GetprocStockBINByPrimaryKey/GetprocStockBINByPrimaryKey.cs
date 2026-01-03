using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procStockBIN.GetprocStockBINLoadAll;

namespace Application.Inventory.Quiries.procStockBIN.GetprocStockBINByPrimaryKey
{
    /// @author  Shimels Alem proc_Stock_BINLoadByPrimaryKey stored procedure.

    public class GetprocStockBINByPrimaryKey : IRequest<GetprocStockBINLoadAllListVm>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
    }
}
