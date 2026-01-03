using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblEnergytype.GetproctblEnergytypeLoadAll;

namespace Application.ProprtyData.Queries.proctblEnergytype.GetproctblEnergytypeByPrimaryKey
{
    /// @author  Shimels Alem proc_tblEnergy_typeLoadByPrimaryKey stored procedure.

    public class GetproctblEnergytypeByPrimaryKey : IRequest<GetproctblEnergytypeLoadAllListVm>
    {
        public long id { get; set; }
    }
}
