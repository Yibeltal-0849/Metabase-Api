using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Document.Quiries.procSendTO.GetprocSendTOLoadAll;

namespace Application.Document.Quiries.procSendTO.GetprocSendTOByPrimaryKey
{
    /// @author  Shimels Alem proc_Send_TOLoadByPrimaryKey stored procedure.

    public class GetprocSendTOByPrimaryKey : IRequest<GetprocSendTOLoadAllListVm>
    {
        public System.Guid Email_ID { get; set; }
    }
}
