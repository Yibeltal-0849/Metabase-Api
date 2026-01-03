using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblEnergyChain.GetproctblEnergyChainLoadAll;

namespace Application.ProprtyData.Queries.proctblEnergyChain.GetproctblEnergyChainByPrimaryKey
{
    /// @author  Shimels Alem proc_tblEnergyChainLoadByPrimaryKey stored procedure.

    public class GetproctblEnergyChainByPrimaryKey : IRequest<GetproctblEnergyChainLoadAllListVm>
    {
        public long id { get; set; }
    }
}
