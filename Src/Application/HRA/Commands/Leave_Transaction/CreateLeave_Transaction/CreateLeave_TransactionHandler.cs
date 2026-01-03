using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Leave_Transaction.CreateLeave_Transaction
{
    public class UpdateLeaveTypeLookup : IRequestHandler<CreateLeaveTypeLookup, IList<LeaveApproval_Leave_Tran_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateLeaveTypeLookup(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LeaveApproval_Leave_Tran_ID>> Handle(CreateLeaveTypeLookup request, CancellationToken cancellationToken)
        {

            IList<LeaveApproval_Leave_Tran_ID> result = await _procedureAdabter
                .Execute<LeaveApproval_Leave_Tran_ID>("[HRA].[proc_Leave_TransactionInsert]", request);

            return result;
        }

    }
}
