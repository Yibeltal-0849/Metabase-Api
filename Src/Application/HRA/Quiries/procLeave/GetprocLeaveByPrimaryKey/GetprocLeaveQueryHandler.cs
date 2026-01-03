using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procLeave.GetprocLeaveLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procLeave.GetprocLeaveByPrimaryKey
{
    public class GetprocLeaveQueryHandler : IRequestHandler<GetLeaveTypeLookupByIdQuery, GetprocLeaveLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLeaveQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLeaveLoadAllListVm> Handle(GetLeaveTypeLookupByIdQuery request, CancellationToken cancellationToken)
        {
           
            IList<Leave> procLeaves = await _procedureAdabter
               .Execute<Leave>("[HRA].[proc_LeaveLoadByPrimaryKey]", request);
            GetprocLeaveLoadAllListVm vm = new GetprocLeaveLoadAllListVm
            {
                procLeaves = _mapper.Map<IList<Leave>, IList<GetprocLeaveLoadAllVm>>(procLeaves)
            };

            return vm;
        }
    }
}
