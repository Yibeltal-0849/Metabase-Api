using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procDocumentArchive.GetprocDocumentArchiveLoadAll;

namespace Application.Finance.Quiries.procDocumentArchive.GetprocDocumentArchiveByPrimaryKey
{
    /// @author  Shimels Alem proc_Document_ArchiveLoadByPrimaryKey stored procedure.

    public class GetprocDocumentArchiveByPrimaryKey : IRequest<GetprocDocumentArchiveLoadAllListVm>
    {
        public string Document_Number { get; set; }
    }
}
