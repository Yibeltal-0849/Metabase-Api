using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationByPrimaryKey
{
    public class GetTraining_ApplicationQueryHandler : IRequestHandler<GetTraining_ApplicationByPrimaryKey, GetTraining_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetTraining_ApplicationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTraining_ApplicationLoadAllListVm> Handle(GetTraining_ApplicationByPrimaryKey request, CancellationToken cancellationToken)
        {
            string Employee_ID = request.Employee_ID;
            Guid Training_Planed_ID = request.Training_Planed_ID;
            IList<TrainingApplication> Training_Applications = await _procedureAdabter
               .Execute<TrainingApplication>("[HRA].[proc_Training_ApplicationLoadByPrimaryKey]", (nameof(Employee_ID), Employee_ID), (nameof(Training_Planed_ID), Training_Planed_ID));
            GetTraining_ApplicationLoadAllListVm vm = new GetTraining_ApplicationLoadAllListVm
            {
                Training_Applications = _mapper.Map<IList<TrainingApplication>, IList<GetTraining_ApplicationLoadAllVm>>(Training_Applications)
            };

            return vm;
        }
    }
}
