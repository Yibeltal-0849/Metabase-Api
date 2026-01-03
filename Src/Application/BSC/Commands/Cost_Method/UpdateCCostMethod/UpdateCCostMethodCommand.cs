using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Cost_Method;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Cost_Method.UpdateCCostMethod
{
    public class UpdateCCostMethodCommand : GetCCostMethodLoadAllVm, IRequest<IList<Proc_C_Cost_Method_ID>>
    {
    }
}
