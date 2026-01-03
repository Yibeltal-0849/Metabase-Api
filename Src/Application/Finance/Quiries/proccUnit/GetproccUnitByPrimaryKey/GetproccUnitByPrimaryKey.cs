using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccUnit.GetproccUnitLoadAll;

namespace Application.Finance.Quiries.proccUnit.GetproccUnitByPrimaryKey
{
    /// @author  Shimels Alem proc_c_UnitLoadByPrimaryKey stored procedure.

    public class GetproccUnitByPrimaryKey : IRequest<GetproccUnitLoadAllListVm>
    {
        public string Unit { get; set; }
    }
}
