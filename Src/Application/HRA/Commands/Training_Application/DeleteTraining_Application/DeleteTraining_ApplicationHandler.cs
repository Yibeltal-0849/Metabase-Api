using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Training_Application.DeleteTraining_Application
{
    public class DeleteTraining_ApplicationHandler : IRequestHandler<DeleteTraining_ApplicationCommand, IList<TrainingApplication_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteTraining_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TrainingApplication_Training_Planed_ID>> Handle(DeleteTraining_ApplicationCommand request, CancellationToken cancellationToken)
        {
            Guid Training_Planed_ID = request.Training_Planed_ID;
            string Employee_ID = request.Employee_ID;

            IList<TrainingApplication_Training_Planed_ID> result = await _procedureAdabter
                .Execute<TrainingApplication_Training_Planed_ID>("[HRA].[proc_Training_ApplicationDelete]",
                (nameof(Training_Planed_ID), Training_Planed_ID),
                (nameof(Employee_ID), Employee_ID));

            return result;
        }
    }
}
