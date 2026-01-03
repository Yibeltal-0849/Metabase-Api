using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSSalesorder.GetprocSSalesorderLoadAll;

namespace Application.Finance.Quiries.procSSalesorder.GetprocSSalesorderByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Sales_orderLoadByPrimaryKey stored procedure.

    public class GetprocSSalesorderByPrimaryKey : IRequest<GetprocSSalesorderLoadAllListVm>
    {
        public string Sales_Order_Line { get; set; }
    }
}
