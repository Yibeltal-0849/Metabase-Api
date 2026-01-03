using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblEnergyProduc.GetproctblEnergyProducLoadAll;

namespace Application.ProprtyData.Queries.proctblEnergyProduc.GetproctblEnergyProducByPrimaryKey
{
    /// @author  Shimels Alem proc_tblEnergyProducLoadByPrimaryKey stored procedure.

    public class GetproctblEnergyProducByPrimaryKey : IRequest<GetproctblEnergyProducLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
