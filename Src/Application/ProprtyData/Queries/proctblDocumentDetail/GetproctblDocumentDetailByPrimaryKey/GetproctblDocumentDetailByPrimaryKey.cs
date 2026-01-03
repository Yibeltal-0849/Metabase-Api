using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblDocumentDetail.GetproctblDocumentDetailLoadAll;

namespace Application.ProprtyData.Queries.proctblDocumentDetail.GetproctblDocumentDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_tblDocument_DetailLoadByPrimaryKey stored procedure.

    public class GetproctblDocumentDetailByPrimaryKey : IRequest<GetproctblDocumentDetailLoadAllListVm>
    {
        public long id { get; set; }
    }
}
