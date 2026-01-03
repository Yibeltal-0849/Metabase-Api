using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSSalseqoute.GetprocSSalseqouteLoadAll;

namespace Application.Finance.Quiries.procSSalseqoute.GetprocSSalseqouteByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Salse_qouteLoadByPrimaryKey stored procedure.

    public class GetprocSSalseqouteByPrimaryKey : IRequest<GetprocSSalseqouteLoadAllListVm>
    {
        public string Sales_Qoute_Line_ID { get; set; }
    }
}
