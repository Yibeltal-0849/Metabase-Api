using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procLeave.GetprocLeaveLoadAll
{
    class GetprocLeaveLoadAllQueryHandler : IRequestHandler<GetprocLeaveLoadAllQuery, GetprocLeaveLoadAllListVm2>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLeaveLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLeaveLoadAllListVm2> Handle(GetprocLeaveLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Leave2> procLeaves = await _procedureAdabter
               .Execute<Leave2>("[HRA].[proc_LeaveLoadAll]");
            GetprocLeaveLoadAllListVm2 vm = new GetprocLeaveLoadAllListVm2
            {
                procLeaves = _mapper.Map<IList<Leave2>, IList<GetprocLeaveLoadAllVm2>>(procLeaves)
            };

            return vm;
        }
    }
}
