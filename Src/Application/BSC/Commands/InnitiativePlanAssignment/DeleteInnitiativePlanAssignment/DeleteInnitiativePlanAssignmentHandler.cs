using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.InnitiativePlanAssignment.DeleteInnitiativePlanAssignment
{
    public class DeleteInnitiativePlanAssignmentHandler : IRequestHandler<DeleteInnitiativePlanAssignmentCommand, IList<Innitiative_Plan_Assignment_IPA_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteInnitiativePlanAssignmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Innitiative_Plan_Assignment_IPA_ID>> Handle(DeleteInnitiativePlanAssignmentCommand request, CancellationToken cancellationToken)
        {
            IList<Innitiative_Plan_Assignment_IPA_ID> result = await _procedureAdabter
                .Execute<Innitiative_Plan_Assignment_IPA_ID>("[BSC].[Innitiative_Plan_AssignmentDelete]", request);

            return result;
        }
    }
}
