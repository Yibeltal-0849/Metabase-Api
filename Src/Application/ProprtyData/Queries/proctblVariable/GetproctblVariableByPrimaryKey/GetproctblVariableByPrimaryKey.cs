using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblVariable.GetproctblVariableLoadAll;

namespace Application.ProprtyData.Queries.proctblVariable.GetproctblVariableByPrimaryKey
{
    /// @author  Shimels Alem proc_tblVariableLoadByPrimaryKey stored procedure.

    public class GetproctblVariableByPrimaryKey : IRequest<GetproctblVariableLoadAllListVm>
    {
        public long id { get; set; }
    }
}
