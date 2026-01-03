using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Document.Quiries.procArchiveType.GetprocArchiveTypeLoadAll;

namespace Application.Document.Quiries.procArchiveType.GetprocArchiveTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Archive_TypeLoadByPrimaryKey stored procedure.

    public class GetprocArchiveTypeByPrimaryKey : IRequest<GetprocArchiveTypeLoadAllListVm>
    {
        public string Name_Type { get; set; }
    }
}
