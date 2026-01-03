using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSalesLines.GetprocSalesLinesLoadAll;

namespace Application.Finance.Quiries.procSalesLines.GetprocSalesLinesByPrimaryKey
{
    /// @author  Shimels Alem proc_Sales_LinesLoadByPrimaryKey stored procedure.

    public class GetprocSalesLinesByPrimaryKey : IRequest<GetprocSalesLinesLoadAllListVm>
    {
        public string Sales_Line_ID { get; set; }
    }
}
