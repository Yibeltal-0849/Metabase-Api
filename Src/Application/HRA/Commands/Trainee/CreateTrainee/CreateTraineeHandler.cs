using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Trainee.CreateTrainee
{
    public class CreateTraineeHandler : IRequestHandler<CreateTraineeCommand, IList<Trainee_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateTraineeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Trainee_Training_Planed_ID>> Handle(CreateTraineeCommand request, CancellationToken cancellationToken)
        {

            IList<Trainee_Training_Planed_ID> result = await _procedureAdabter
                    .Execute<Trainee_Training_Planed_ID>("[HRA].[TraineeInsert]", request);

            return result;
        }

    }
}
