using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procWorkInfo.GetprocWorkInfoLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procWorkInfo.procWorkInfoLoadByPrimaryKeyStractureID
{
    public class GetprocWorkInfoQueryHandler : IRequestHandler<procWorkInfoLoadByPrimaryKeyStractureID, GetprocWorkInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocWorkInfoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWorkInfoLoadAllListVm> Handle(procWorkInfoLoadByPrimaryKeyStractureID request, CancellationToken cancellationToken)
        {
           
            IList<WorkInfo> procWorkInfos = await _procedureAdabter
               .Execute<WorkInfo>("[HRA].[procWorkInfoLoadByPrimaryKeyStractureID]", request);
            GetprocWorkInfoLoadAllListVm vm = new GetprocWorkInfoLoadAllListVm
            {
                procWorkInfos = _mapper.Map<IList<WorkInfo>, IList<GetprocWorkInfoLoadAllVm>>(procWorkInfos)
            };

            return vm;
        }
    }
}
