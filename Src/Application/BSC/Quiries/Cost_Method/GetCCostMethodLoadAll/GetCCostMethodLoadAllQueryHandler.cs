using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Cost_Method.GetCCostMethodLoadAll
{
    public class GetCCostMethodLoadAllQueryHandler : IRequestHandler<GetCCostMethodLoadAllQuery, GetCCostMethodLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCCostMethodLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCCostMethodLoadAllListVm> Handle(GetCCostMethodLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Cost_Method> costMethods = await _procedureAdabter
               .Execute<Proc_C_Cost_Method>("[BSC].[proc_c_Cost_MethodLoadAll]");
            GetCCostMethodLoadAllListVm vm = new GetCCostMethodLoadAllListVm
            {
                CostMethods = _mapper.Map<IList<Proc_C_Cost_Method>, IList<GetCCostMethodLoadAllVm>>(costMethods)
            };

            return vm;
        }
    }
}
