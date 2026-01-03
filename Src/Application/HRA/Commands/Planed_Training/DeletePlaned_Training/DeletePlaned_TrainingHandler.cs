using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Planed_Training.DeletePlaned_Training
{
    public class DeletePlaned_TrainingHandler : IRequestHandler<DeletePlaned_TrainingCommand, IList<PlanedTraining_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeletePlaned_TrainingHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PlanedTraining_Training_Planed_ID>> Handle(DeletePlaned_TrainingCommand request, CancellationToken cancellationToken)
        {
            Guid Training_Planed_ID = request.Training_Planed_ID;
            IList<PlanedTraining_Training_Planed_ID> result = await _procedureAdabter
                .Execute<PlanedTraining_Training_Planed_ID>("[HRA].[proc_Planed_TrainingDelete]",
                (nameof(Training_Planed_ID), Training_Planed_ID));

            return result;
        }
    }
}
