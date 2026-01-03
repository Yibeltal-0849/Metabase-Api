using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Leave_Approval.CreateLeave_Approval
{
    public class CreateLeave_ApprovalHandler : IRequestHandler<CreateLeave_ApprovalCommand, IList<LeaveApproval_Leave_Tran_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateLeave_ApprovalHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LeaveApproval_Leave_Tran_ID>> Handle(CreateLeave_ApprovalCommand request, CancellationToken cancellationToken)
        {

            IList<LeaveApproval_Leave_Tran_ID> result = await _procedureAdabter
                .Execute<LeaveApproval_Leave_Tran_ID>("[HRA].[Leave_ApprovalInsert]", request);

            return result;
        }

    }
}
