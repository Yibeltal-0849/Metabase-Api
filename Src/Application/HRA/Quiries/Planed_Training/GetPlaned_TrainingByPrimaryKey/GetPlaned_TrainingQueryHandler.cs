using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Planed_Training.GetPlaned_TrainingLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Planed_Training.GetPlaned_TrainingByPrimaryKey
{
    public class GetPlaned_TrainingQueryHandler : IRequestHandler<GetPlaned_TrainingByPrimaryKey, GetPlaned_TrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetPlaned_TrainingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetPlaned_TrainingLoadAllListVm> Handle(GetPlaned_TrainingByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid Training_Planed_ID = request.Training_Planed_ID;
            IList<PlanedTraining> Planed_Trainings = await _procedureAdabter
               .Execute<PlanedTraining>("[HRA].[proc_Planed_TrainingLoadByPrimaryKey]", (nameof(Training_Planed_ID), Training_Planed_ID));
            GetPlaned_TrainingLoadAllListVm vm = new GetPlaned_TrainingLoadAllListVm
            {
                Planed_Trainings = _mapper.Map<IList<PlanedTraining>, IList<GetPlaned_TrainingLoadAllVm>>(Planed_Trainings)
            };

            return vm;
        }
    }
}
