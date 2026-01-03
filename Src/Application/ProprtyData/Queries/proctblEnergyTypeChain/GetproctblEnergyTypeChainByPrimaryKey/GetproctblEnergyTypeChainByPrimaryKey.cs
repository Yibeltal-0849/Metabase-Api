using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblEnergyTypeChain.GetproctblEnergyTypeChainLoadAll;

namespace Application.ProprtyData.Queries.proctblEnergyTypeChain.GetproctblEnergyTypeChainByPrimaryKey
{
    /// @author  Shimels Alem proc_tblEnergy_Type_ChainLoadByPrimaryKey stored procedure.

    public class GetproctblEnergyTypeChainByPrimaryKey : IRequest<GetproctblEnergyTypeChainLoadAllListVm>
    {
        public long id { get; set; }
    }
}
