using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSSalesReturnOrder.GetprocSSalesReturnOrderLoadAll;

namespace Application.Finance.Quiries.procSSalesReturnOrder.GetprocSSalesReturnOrderByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Sales_Return_OrderLoadByPrimaryKey stored procedure.

    public class GetprocSSalesReturnOrderByPrimaryKey : IRequest<GetprocSSalesReturnOrderLoadAllListVm>
    {
        public string Sales_Return_Order_Line { get; set; }
    }
}
