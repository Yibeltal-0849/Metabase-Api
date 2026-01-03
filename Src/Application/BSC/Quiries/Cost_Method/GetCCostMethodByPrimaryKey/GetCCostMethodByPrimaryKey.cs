using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Cost_Method.GetCCostMethodLoadAll;

namespace XOKA.Application.BSC.Quiries.Cost_Method.GetCCostMethodByPrimaryKey
{
    public class GetCCostMethodByPrimaryKey : IRequest<GetCCostMethodLoadAllListVm>
    {
        public string ID { get; set; }
    }
}
