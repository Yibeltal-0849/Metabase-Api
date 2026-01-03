using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Training.DeleteTraining
{
    public class DeleteTrainingHandler : IRequestHandler<DeleteTrainingCommand, IList<Training_Training_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteTrainingHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Training_Training_ID>> Handle(DeleteTrainingCommand request, CancellationToken cancellationToken)
        {
            string Training_ID = request.Training_ID;
            IList<Training_Training_ID> result = await _procedureAdabter
                .Execute<Training_Training_ID>("[HRA].[TrainingDelete]",
                (nameof(Training_ID), Training_ID));

            return result;
        }
    }
}
