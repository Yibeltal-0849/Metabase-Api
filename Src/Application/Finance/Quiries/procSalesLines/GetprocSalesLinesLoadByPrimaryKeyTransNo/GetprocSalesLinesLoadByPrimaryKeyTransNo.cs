using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSalesLines.GetprocSalesLinesLoadAll;

namespace Application.Finance.Quiries.procSalesLines.GetprocSalesLinesLoadByPrimaryKeyTransNo
{
    /// @author  Shimels Alem proc_Sales_LinesLoadByPrimaryKey stored procedure.

    public class GetprocSalesLinesLoadByPrimaryKeyTransNo : IRequest<GetprocSalesLinesLoadAllListVm>
    {
        public string Trans_No { get; set; }
    }
}
