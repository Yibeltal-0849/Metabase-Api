using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Document.Quiries.procArchive.GetprocArchiveLoadAll;

namespace Application.Document.Quiries.procArchive.GetprocArchiveByPrimaryKey
{
    /// @author  Shimels Alem proc_ArchiveLoadByPrimaryKey stored procedure.

    public class GetprocArchiveByPrimaryKey : IRequest<GetprocArchiveLoadAllListVm>
    {
        public Guid Letter_ID { get; set; }
    }
}
