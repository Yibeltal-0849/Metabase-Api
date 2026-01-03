using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Training.CreateTraining
{
    public class CreateTrainingHandler : IRequestHandler<CreateTrainingCommand, IList<Training_Training_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateTrainingHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Training_Training_ID>> Handle(CreateTrainingCommand request, CancellationToken cancellationToken)
        {

            IList<Training_Training_ID> result = await _procedureAdabter
                    .Execute<Training_Training_ID>("[HRA].[TrainingInsert]", request);

            return result;
        }

    }
}
