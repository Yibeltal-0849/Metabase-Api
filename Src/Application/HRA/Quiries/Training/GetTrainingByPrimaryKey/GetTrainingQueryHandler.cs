using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.Training.GetTrainingLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.Training.GetTrainingByPrimaryKey
{
    public class GetTrainingQueryHandler : IRequestHandler<GetTrainingByPrimaryKey, GetTrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetTrainingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTrainingLoadAllListVm> Handle(GetTrainingByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_Training> Trainings = await _procedureAdabter
               .Execute<_Training>("[HRA].[proc_TrainingLoadByPrimaryKey]", request);
            GetTrainingLoadAllListVm vm = new GetTrainingLoadAllListVm
            {
                Trainings = _mapper.Map<IList<_Training>, IList<GetTrainingLoadAllVm>>(Trainings)
            };

            return vm;
        }
    }
}
