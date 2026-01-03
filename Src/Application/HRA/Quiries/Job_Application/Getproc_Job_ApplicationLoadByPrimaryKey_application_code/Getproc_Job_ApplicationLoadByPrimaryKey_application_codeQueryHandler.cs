using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Job_Application.GetJob_ApplicationLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Job_Application.Getproc_Job_ApplicationLoadByPrimaryKey_application_code
{
    public class GetJob_ApplicationQueryHandler : IRequestHandler<Getproc_Job_ApplicationLoadByPrimaryKey_application_code, GetJob_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetJob_ApplicationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetJob_ApplicationLoadAllListVm> Handle(Getproc_Job_ApplicationLoadByPrimaryKey_application_code request, CancellationToken cancellationToken)
        {
            Guid application_code = request.application_code;
            IList<JobApplication> Job_Applications = await _procedureAdabter
               .Execute<JobApplication>("[HRA].[proc_Job_ApplicationLoadByPrimaryKey_application_code]", (nameof(application_code), application_code));
            GetJob_ApplicationLoadAllListVm vm = new GetJob_ApplicationLoadAllListVm
            {
                Job_Applications = _mapper.Map<IList<JobApplication>, IList<GetJob_ApplicationLoadAllVm>>(Job_Applications)
            };

            return vm;
        }
    }
}
