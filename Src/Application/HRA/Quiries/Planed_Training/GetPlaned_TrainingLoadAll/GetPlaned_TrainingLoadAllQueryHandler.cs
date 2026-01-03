using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Planed_Training.GetPlaned_TrainingLoadAll
{
    class GetPlaned_TrainingLoadAllQueryHandler : IRequestHandler<GetPlaned_TrainingLoadAllQuery, GetPlaned_TrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetPlaned_TrainingLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetPlaned_TrainingLoadAllListVm> Handle(GetPlaned_TrainingLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PlanedTraining> Planed_Trainings = await _procedureAdabter
               .Execute<PlanedTraining>("[HRA].[proc_Planed_TrainingLoadAll]");
            GetPlaned_TrainingLoadAllListVm vm = new GetPlaned_TrainingLoadAllListVm
            {
                Planed_Trainings = _mapper.Map<IList<PlanedTraining>, IList<GetPlaned_TrainingLoadAllVm>>(Planed_Trainings)
            };

            return vm;
        }
    }
}
