using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective.GetAnnualStrategyGolsWithPerspectiveGoalsLoadAll;

namespace XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective.GetprocAnnualStrategyGolsWithPerspectiveGoalsLoadByPrimaryKeyPerspectiveID
{
    public class GetprocAnnualStrategyGolsWithPerspectiveGoalsLoadByPrimaryKeyPerspectiveID : IRequest<GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllListVm>
    {
        public string Perspective_ID { get; set; }
    }
}
