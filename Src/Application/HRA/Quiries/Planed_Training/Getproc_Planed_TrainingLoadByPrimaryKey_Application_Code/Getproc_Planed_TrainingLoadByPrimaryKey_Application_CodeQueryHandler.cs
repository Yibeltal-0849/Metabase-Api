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

namespace XOKA.Application.HRA.Quiries.Planed_Training.Getproc_Planed_TrainingLoadByPrimaryKey_Application_Code
{
    public class GetPlaned_TrainingQueryHandler : IRequestHandler<Getproc_Planed_TrainingLoadByPrimaryKey_Application_Code, GetPlaned_TrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetPlaned_TrainingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetPlaned_TrainingLoadAllListVm> Handle(Getproc_Planed_TrainingLoadByPrimaryKey_Application_Code request, CancellationToken cancellationToken)
        {
            Guid Application_Code = request.Application_Code;
            IList<PlanedTraining> Planed_Trainings = await _procedureAdabter
               .Execute<PlanedTraining>("[HRA].[proc_Planed_TrainingLoadByPrimaryKey_Application_Code]", (nameof(Application_Code), Application_Code));
            GetPlaned_TrainingLoadAllListVm vm = new GetPlaned_TrainingLoadAllListVm
            {
                Planed_Trainings = _mapper.Map<IList<PlanedTraining>, IList<GetPlaned_TrainingLoadAllVm>>(Planed_Trainings)
            };

            return vm;
        }
    }
}
