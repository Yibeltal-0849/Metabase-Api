using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Planed_Training.UpdatePlaned_Training
{
    public class UpdatePlaned_TrainingHandler : IRequestHandler<UpdatePlaned_TrainingCommand, IList<PlanedTraining_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdatePlaned_TrainingHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PlanedTraining_Training_Planed_ID>> Handle(UpdatePlaned_TrainingCommand request, CancellationToken cancellationToken)
        {

            IList<PlanedTraining_Training_Planed_ID> result = await _procedureAdabter
                .Execute<PlanedTraining_Training_Planed_ID>("[HRA].[proc_Planed_TrainingUpdate]", request);

            return result;
        }
    }
}
