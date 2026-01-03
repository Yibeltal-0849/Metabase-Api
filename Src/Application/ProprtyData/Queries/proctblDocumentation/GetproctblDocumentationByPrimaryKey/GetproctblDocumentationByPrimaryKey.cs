using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Quiries.proctblDocumentation.GetproctblDocumentationLoadAll;

namespace Application.ProprtyData.Quiries.proctblDocumentation.GetproctblDocumentationByPrimaryKey
{
    /// @author  Shimels Alem proc_tblDocumentationLoadByPrimaryKey stored procedure.

    public class GetproctblDocumentationByPrimaryKey : IRequest<GetproctblDocumentationLoadAllListVm>
    {
        public long? id { get; set; }
    }
}
