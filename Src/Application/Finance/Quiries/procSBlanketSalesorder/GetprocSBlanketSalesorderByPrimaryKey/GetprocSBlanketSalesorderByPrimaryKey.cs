using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSBlanketSalesorder.GetprocSBlanketSalesorderLoadAll;

namespace Application.Finance.Quiries.procSBlanketSalesorder.GetprocSBlanketSalesorderByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Blanket_Sales_orderLoadByPrimaryKey stored procedure.

    public class GetprocSBlanketSalesorderByPrimaryKey : IRequest<GetprocSBlanketSalesorderLoadAllListVm>
    {
        public string Sales_Blanket_Order_Line { get; set; }
    }
}
