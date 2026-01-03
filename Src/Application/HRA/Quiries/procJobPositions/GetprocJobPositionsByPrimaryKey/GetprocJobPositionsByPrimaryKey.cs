using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procJobPositions.GetprocJobPositionsLoadAll;

namespace Application.HRA.Quiries.procJobPositions.GetprocJobPositionsByPrimaryKey
{
    /// @author  Shimels Alem proc_Job_PositionsLoadByPrimaryKey stored procedure.

    public class GetprocJobPositionsByPrimaryKey : IRequest<GetprocJobPositionsLoadAllListVm>
    {
       public Guid Pos_ID { get; set; }
    }
}
