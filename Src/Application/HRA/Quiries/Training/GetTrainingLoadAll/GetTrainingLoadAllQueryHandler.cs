using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.Training.GetTrainingLoadAll
{
    class GetTrainingLoadAllQueryHandler : IRequestHandler<GetTrainingLoadAllQuery, GetTrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetTrainingLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTrainingLoadAllListVm> Handle(GetTrainingLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Training> Trainings = await _procedureAdabter
               .Execute<_Training>("[HRA].[proc_TrainingLoadAll]");
            GetTrainingLoadAllListVm vm = new GetTrainingLoadAllListVm
            {
                Trainings = _mapper.Map<IList<_Training>, IList<GetTrainingLoadAllVm>>(Trainings)
            };

            return vm;
        }
    }
}
