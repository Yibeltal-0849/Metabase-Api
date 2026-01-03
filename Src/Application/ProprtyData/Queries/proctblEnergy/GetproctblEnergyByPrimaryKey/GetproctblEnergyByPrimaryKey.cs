using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblEnergy.GetproctblEnergyLoadAll;

namespace Application.ProprtyData.Queries.proctblEnergy.GetproctblEnergyByPrimaryKey
{
    /// @author  Shimels Alem proc_tblEnergyLoadByPrimaryKey stored procedure.

    public class GetproctblEnergyByPrimaryKey : IRequest<GetproctblEnergyLoadAllListVm>
    {
        public long id { get; set; }
    }
}
