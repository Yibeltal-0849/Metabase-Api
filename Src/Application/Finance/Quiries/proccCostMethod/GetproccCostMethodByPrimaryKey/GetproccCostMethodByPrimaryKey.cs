using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccCostMethod.GetproccCostMethodLoadAll;

namespace Application.Finance.Quiries.proccCostMethod.GetproccCostMethodByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Cost_MethodLoadByPrimaryKey stored procedure.

    public class GetproccCostMethodByPrimaryKey : IRequest<GetproccCostMethodLoadAllListVm>
    {
        public string ID { get; set; }
    }
}
