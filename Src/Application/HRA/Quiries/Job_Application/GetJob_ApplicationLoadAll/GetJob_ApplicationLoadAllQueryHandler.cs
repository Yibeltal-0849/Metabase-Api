using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Job_Application.GetJob_ApplicationLoadAll
{
    class GetJob_ApplicationLoadAllQueryHandler : IRequestHandler<GetJob_ApplicationLoadAllQuery, GetJob_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetJob_ApplicationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetJob_ApplicationLoadAllListVm> Handle(GetJob_ApplicationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JobApplication> Job_Applications = await _procedureAdabter
               .Execute<JobApplication>("[HRA].[proc_Job_ApplicationLoadAll]");
            GetJob_ApplicationLoadAllListVm vm = new GetJob_ApplicationLoadAllListVm
            {
                Job_Applications = _mapper.Map<IList<JobApplication>, IList<GetJob_ApplicationLoadAllVm>>(Job_Applications)
            };

            return vm;
        }
    }
}
