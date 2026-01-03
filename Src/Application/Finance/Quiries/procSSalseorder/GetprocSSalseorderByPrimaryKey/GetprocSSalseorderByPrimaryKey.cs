using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSSalseorder.GetprocSSalseorderLoadAll;

namespace Application.Finance.Quiries.procSSalseorder.GetprocSSalseorderByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Salse_orderLoadByPrimaryKey stored procedure.

    public class GetprocSSalseorderByPrimaryKey : IRequest<GetprocSSalseorderLoadAllListVm>
    {
        public string Sales_Order_Line_ID { get; set; }
    }
}
