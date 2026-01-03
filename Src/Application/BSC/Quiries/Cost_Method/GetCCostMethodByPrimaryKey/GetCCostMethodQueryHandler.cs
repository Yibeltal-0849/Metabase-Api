using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Cost_Method.GetCCostMethodLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Cost_Method.GetCCostMethodByPrimaryKey
{
    class GetCCostMethodQueryHandler : IRequestHandler<GetCCostMethodByPrimaryKey, GetCCostMethodLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCCostMethodQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCCostMethodLoadAllListVm> Handle(GetCCostMethodByPrimaryKey request, CancellationToken cancellationToken)
        {
            string ID = request.ID;
            IList<Proc_C_Cost_Method> costMethods = await _procedureAdabter
               .Execute<Proc_C_Cost_Method>("[BSC].[proc_c_Cost_MethodLoadByPrimaryKey]", (nameof(ID), ID));
            GetCCostMethodLoadAllListVm vm = new GetCCostMethodLoadAllListVm
            {
                CostMethods = _mapper.Map<IList<Proc_C_Cost_Method>, IList<GetCCostMethodLoadAllVm>>(costMethods)
            };

            return vm;
        }
    }
}
