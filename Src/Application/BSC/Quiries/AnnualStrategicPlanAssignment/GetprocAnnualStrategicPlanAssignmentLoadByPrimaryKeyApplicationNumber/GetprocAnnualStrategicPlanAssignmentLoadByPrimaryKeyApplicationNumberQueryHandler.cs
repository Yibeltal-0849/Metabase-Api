using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetAnnualStrategicPlanAssignmentLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyApplicationNumber
{
    public class GetAnnualStrategicPlanAssignmentQueryHandler : IRequestHandler<GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyApplicationNumber, GetAnnualStrategicPlanAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAnnualStrategicPlanAssignmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetAnnualStrategicPlanAssignmentLoadAllListVm> Handle(GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
            string Application_Number = request.Application_Number;
            IList<Proc_Annual_Strategic_Plan_Assignment> annualStrategicPlans = await _procedureAdabter
               .Execute<Proc_Annual_Strategic_Plan_Assignment>("[BSC].[proc_Annual_Strategic_Plan_AssignmentLoadByPrimaryKey_Application_Number]", (nameof(Application_Number), Application_Number));
            GetAnnualStrategicPlanAssignmentLoadAllListVm vm = new GetAnnualStrategicPlanAssignmentLoadAllListVm
            {
                AnnualStrategicPlans = _mapper.Map<IList<Proc_Annual_Strategic_Plan_Assignment>, IList<GetAnnualStrategicPlanAssignmentLoadAllVm>>(annualStrategicPlans)
            };

            return vm;
        }
    }
}
