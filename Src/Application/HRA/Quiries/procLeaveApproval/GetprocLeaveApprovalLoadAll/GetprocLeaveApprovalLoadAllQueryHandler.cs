using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procLeaveApproval.GetprocLeaveApprovalLoadAll
{
    class GetprocLeaveApprovalLoadAllQueryHandler : IRequestHandler<GetprocLeaveApprovalLoadAllQuery, GetprocLeaveApprovalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLeaveApprovalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLeaveApprovalLoadAllListVm> Handle(GetprocLeaveApprovalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LeaveApproval> procLeaveApprovals = await _procedureAdabter
               .Execute<LeaveApproval>("[HRA].[proc_Leave_ApprovalLoadAll]");
            GetprocLeaveApprovalLoadAllListVm vm = new GetprocLeaveApprovalLoadAllListVm
            {
                procLeaveApprovals = _mapper.Map<IList<LeaveApproval>, IList<GetprocLeaveApprovalLoadAllVm>>(procLeaveApprovals)
            };

            return vm;
        }
    }
}
