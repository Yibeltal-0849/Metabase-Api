using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetAnnualStrategicPlanAssignmentLoadAll
{
    class GetAnnualStrategicPlanAssignmentLoadAllQueryHandler : IRequestHandler<GetAnnualStrategicPlanAssignmentLoadAllQuery, GetAnnualStrategicPlanAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetAnnualStrategicPlanAssignmentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetAnnualStrategicPlanAssignmentLoadAllListVm> Handle(GetAnnualStrategicPlanAssignmentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_Annual_Strategic_Plan_Assignment> annualStrategicPlans = await _procedureAdabter
               .Execute<Proc_Annual_Strategic_Plan_Assignment>("[BSC].[proc_Annual_Strategic_Plan_AssignmentLoadAll]");
            GetAnnualStrategicPlanAssignmentLoadAllListVm vm = new GetAnnualStrategicPlanAssignmentLoadAllListVm
            {
                AnnualStrategicPlans = _mapper.Map<IList<Proc_Annual_Strategic_Plan_Assignment>, IList<GetAnnualStrategicPlanAssignmentLoadAllVm>>(annualStrategicPlans)
            };

            return vm;
        }
    }
}
