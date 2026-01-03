using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSSalescreaditmemeo.GetprocSSalescreaditmemeoLoadAll;

namespace Application.Finance.Quiries.procSSalescreaditmemeo.GetprocSSalescreaditmemeoByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Sales_creadit_memeoLoadByPrimaryKey stored procedure.

    public class GetprocSSalescreaditmemeoByPrimaryKey : IRequest<GetprocSSalescreaditmemeoLoadAllListVm>
    {
        public string Sales_Credit_Line_Id { get; set; }
    }
}
