using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Trainee.DeleteTrainee
{
    public class DeleteTraineeHandler : IRequestHandler<DeleteTraineeCommand, IList<Trainee_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteTraineeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Trainee_Training_Planed_ID>> Handle(DeleteTraineeCommand request, CancellationToken cancellationToken)
        {
            Guid? Training_Planed_ID = request.Training_Planed_ID;
            IList<Trainee_Training_Planed_ID> result = await _procedureAdabter
                .Execute<Trainee_Training_Planed_ID>("[HRA].[TraineeDelete]",
                (nameof(Training_Planed_ID), Training_Planed_ID));

            return result;
        }
    }
}
