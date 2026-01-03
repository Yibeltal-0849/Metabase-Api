using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Training_Application.UpdateTraining_Application
{
    public class UpdateTraining_ApplicationHandler : IRequestHandler<UpdateTraining_ApplicationCommand, IList<TrainingApplication_Training_Planed_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateTraining_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TrainingApplication_Training_Planed_ID>> Handle(UpdateTraining_ApplicationCommand request, CancellationToken cancellationToken)
        {

            IList<TrainingApplication_Training_Planed_ID> result = await _procedureAdabter
                .Execute<TrainingApplication_Training_Planed_ID>("[HRA].[proc_Training_ApplicationUpdate]", request);

            return result;
        }
    }
}
