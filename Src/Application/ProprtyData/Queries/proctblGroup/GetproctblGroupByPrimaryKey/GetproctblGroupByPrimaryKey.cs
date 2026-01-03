using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblGroup.GetproctblGroupLoadAll;

namespace Application.ProprtyData.Queries.proctblGroup.GetproctblGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_tblGroupLoadByPrimaryKey stored procedure.

    public class GetproctblGroupByPrimaryKey : IRequest<GetproctblGroupLoadAllListVm>
    {
        public long id { get; set; }
    }
}
