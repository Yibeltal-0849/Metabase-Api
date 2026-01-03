using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Cost_Method.DeleteCCostMethod
{
    public class DeleteCCostMethodCommand : IRequest<IList<Proc_C_Cost_Method_ID>>
    {
        public string ID { get; set; }
    }
}
