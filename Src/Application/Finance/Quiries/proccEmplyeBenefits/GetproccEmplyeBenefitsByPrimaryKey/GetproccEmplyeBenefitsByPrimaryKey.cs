using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccEmplyeBenefits.GetproccEmplyeBenefitsLoadAll;

namespace Application.Finance.Quiries.proccEmplyeBenefits.GetproccEmplyeBenefitsByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Emplye_BenefitsLoadByPrimaryKey stored procedure.

    public class GetproccEmplyeBenefitsByPrimaryKey : IRequest<GetproccEmplyeBenefitsLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
