using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblGroupcons.GetproctblGroupconsLoadAll;

namespace Application.ProprtyData.Queries.proctblGroupcons.GetproctblGroupconsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblGroup_consLoadByPrimaryKey stored procedure.

    public class GetproctblGroupconsByPrimaryKey : IRequest<GetproctblGroupconsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
