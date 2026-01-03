using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Planed_Training.CreatePlaned_Training
{
    public class CreatePlaned_TrainingHandler : IRequestHandler<CreatePlaned_TrainingCommand, IList<PlanedTraining_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreatePlaned_TrainingHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PlanedTraining_Training_Planed_ID>> Handle(CreatePlaned_TrainingCommand request, CancellationToken cancellationToken)
        {

            IList<PlanedTraining_Training_Planed_ID> result = await _procedureAdabter
                    .Execute<PlanedTraining_Training_Planed_ID>("[HRA].[proc_Planed_TrainingInsert]", request);

            return result;
        }

    }
}
