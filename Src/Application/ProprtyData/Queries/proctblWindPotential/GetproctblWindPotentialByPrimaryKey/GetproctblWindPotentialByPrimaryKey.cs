using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblWindPotential.GetproctblWindPotentialLoadAll;

namespace Application.ProprtyData.Queries.proctblWindPotential.GetproctblWindPotentialByPrimaryKey
{
    /// @author  Shimels Alem proc_tblWindPotentialLoadByPrimaryKey stored procedure.

    public class GetproctblWindPotentialByPrimaryKey : IRequest<GetproctblWindPotentialLoadAllListVm>
    {
        public long id { get; set; }
    }
}
