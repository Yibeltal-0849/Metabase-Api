using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblDocumentType.GetproctblDocumentTypeLoadAll;

namespace Application.ProprtyData.Queries.proctblDocumentType.GetproctblDocumentTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_tblDocument_TypeLoadByPrimaryKey stored procedure.

    public class GetproctblDocumentTypeByPrimaryKey : IRequest<GetproctblDocumentTypeLoadAllListVm>
    {
        public long id { get; set; }
    }
}
