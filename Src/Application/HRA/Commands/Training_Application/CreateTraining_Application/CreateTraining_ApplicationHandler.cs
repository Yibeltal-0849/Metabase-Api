using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Training_Application.CreateTraining_Application
{
    public class CreateTraining_ApplicationHandler : IRequestHandler<CreateTraining_ApplicationCommand, IList<TrainingApplication_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateTraining_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TrainingApplication_Training_Planed_ID>> Handle(CreateTraining_ApplicationCommand request, CancellationToken cancellationToken)
        {

            IList<TrainingApplication_Training_Planed_ID> result = await _procedureAdabter
                    .Execute<TrainingApplication_Training_Planed_ID>("[HRA].[Training_ApplicationInsert]", request);

            return result;
        }

    }
}
