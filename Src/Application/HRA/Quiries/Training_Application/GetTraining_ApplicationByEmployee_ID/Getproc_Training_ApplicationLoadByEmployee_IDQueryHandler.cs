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

namespace XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationByEmployee_ID
{
    public class GetTraining_ApplicationQueryHandler : IRequestHandler<GetTraining_ApplicationByEmployee_ID, GetTraining_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetTraining_ApplicationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTraining_ApplicationLoadAllListVm> Handle(GetTraining_ApplicationByEmployee_ID request, CancellationToken cancellationToken)
        {
            string Employee_ID = request.Employee_ID;
            IList<TrainingApplication> Training_Applications = await _procedureAdabter
               .Execute<TrainingApplication>("[HRA].[proc_Training_ApplicationLoadByEmployee_ID]", (nameof(Employee_ID), Employee_ID));
            GetTraining_ApplicationLoadAllListVm vm = new GetTraining_ApplicationLoadAllListVm
            {
                Training_Applications = _mapper.Map<IList<TrainingApplication>, IList<GetTraining_ApplicationLoadAllVm>>(Training_Applications)
            };

            return vm;
        }
    }
}
