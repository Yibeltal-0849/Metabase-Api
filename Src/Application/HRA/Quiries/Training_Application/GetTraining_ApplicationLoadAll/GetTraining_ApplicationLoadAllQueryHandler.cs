using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationLoadAll
{
    class GetTraining_ApplicationLoadAllQueryHandler : IRequestHandler<GetTraining_ApplicationLoadAllQuery, GetTraining_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetTraining_ApplicationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTraining_ApplicationLoadAllListVm> Handle(GetTraining_ApplicationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TrainingApplication> Training_Applications = await _procedureAdabter
               .Execute<TrainingApplication>("[HRA].[proc_Training_ApplicationLoadAll]");
            GetTraining_ApplicationLoadAllListVm vm = new GetTraining_ApplicationLoadAllListVm
            {
                Training_Applications = _mapper.Map<IList<TrainingApplication>, IList<GetTraining_ApplicationLoadAllVm>>(Training_Applications)
            };

            return vm;
        }
    }
}
