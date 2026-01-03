using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Queries.procAdjudicated.GetprocAdjudicatedLoadAll;

namespace Application.dbo.Queries.procAdjudicated.GetprocAdjudicatedLoadByPrimaryKey
{
    public class GetprocAdjudicatedByPrimaryKey : IRequest<GetprocAdjudicatedLoadAllListVm>
    {
        public System.Guid Adjudicated_Code { get; set; }
    }
}
