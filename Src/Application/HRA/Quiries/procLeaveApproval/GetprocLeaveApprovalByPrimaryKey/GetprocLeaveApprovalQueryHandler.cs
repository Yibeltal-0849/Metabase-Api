using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procLeaveApproval.GetprocLeaveApprovalLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procLeaveApproval.GetprocLeaveApprovalByPrimaryKey
{
    public class GetprocLeaveApprovalQueryHandler : IRequestHandler<GetprocLeaveApprovalByPrimaryKey, GetprocLeaveApprovalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLeaveApprovalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLeaveApprovalLoadAllListVm> Handle(GetprocLeaveApprovalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LeaveApproval> procLeaveApprovals = await _procedureAdabter
               .Execute<LeaveApproval>("[HRA].[proc_Leave_ApprovalLoadByPrimaryKey]", request);
            GetprocLeaveApprovalLoadAllListVm vm = new GetprocLeaveApprovalLoadAllListVm
            {
                procLeaveApprovals = _mapper.Map<IList<LeaveApproval>, IList<GetprocLeaveApprovalLoadAllVm>>(procLeaveApprovals)
            };

            return vm;
        }
    }
}
