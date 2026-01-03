using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Leave_Transaction.DeleteLeave_Transaction
{
    public class DeleteLeave_TransactionHandler : IRequestHandler<DeleteLeave_TransactionCommand, IList<LeaveApproval_Leave_Tran_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteLeave_TransactionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LeaveApproval_Leave_Tran_ID>> Handle(DeleteLeave_TransactionCommand request, CancellationToken cancellationToken)
        {
            Guid Leave_Tran_ID = request.Leave_Tran_ID;
            IList<LeaveApproval_Leave_Tran_ID> result = await _procedureAdabter
                .Execute<LeaveApproval_Leave_Tran_ID>("[HRA].[proc_Leave_TransactionDelete]",
                (nameof(Leave_Tran_ID), Leave_Tran_ID));

            return result;
        }
    }
}
