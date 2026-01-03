using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblState.GetproctblStateLoadAll;

namespace Application.ProprtyData.Queries.proctblState.GetproctblStateByPrimaryKey
{
    /// @author  Shimels Alem proc_tblStateLoadByPrimaryKey stored procedure.

    public class GetproctblStateByPrimaryKey : IRequest<GetproctblStateLoadAllListVm>
    {
        public long id { get; set; }
    }
}
