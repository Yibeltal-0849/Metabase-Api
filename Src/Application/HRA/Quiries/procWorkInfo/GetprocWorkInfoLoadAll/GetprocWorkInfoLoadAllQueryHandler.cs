using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procWorkInfo.GetprocWorkInfoLoadAll
{
    class GetprocWorkInfoLoadAllQueryHandler : IRequestHandler<GetprocWorkInfoLoadAllQuery, GetprocWorkInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocWorkInfoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWorkInfoLoadAllListVm> Handle(GetprocWorkInfoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<WorkInfo> procWorkInfos = await _procedureAdabter
               .Execute<WorkInfo>("[HRA].[proc_Work_InfoLoadAll]");
            GetprocWorkInfoLoadAllListVm vm = new GetprocWorkInfoLoadAllListVm
            {
                procWorkInfos = _mapper.Map<IList<WorkInfo>, IList<GetprocWorkInfoLoadAllVm>>(procWorkInfos)
            };

            return vm;
        }
    }
}
