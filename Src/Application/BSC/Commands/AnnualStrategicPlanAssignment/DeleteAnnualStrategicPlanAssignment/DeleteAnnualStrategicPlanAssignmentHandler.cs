using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.AnnualStrategicPlanAssignment.DeleteAnnualStrategicPlanAssignment
{
    public class DeleteAnnualStrategicPlanAssignmentHandler : IRequestHandler<DeleteAnnualStrategicPlanAssignmentCommand, IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteAnnualStrategicPlanAssignmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>> Handle(DeleteAnnualStrategicPlanAssignmentCommand request, CancellationToken cancellationToken)
        {
            System.Guid?ASPA_ID = request.ASPA_ID;
            IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID> result = await _procedureAdabter
                .Execute<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>("[BSC].[proc_Annual_Strategic_Plan_AssignmentDelete]", (nameof(ASPA_ID), ASPA_ID));

            return result;

        }
    }
}
