using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Leave_Transaction.UpdateLeave_Transaction
{
    public class UpdateLeave_TransactionHandler : IRequestHandler<UpdateLeave_TransactionCommand, IList<LeaveApproval_Leave_Tran_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateLeave_TransactionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LeaveApproval_Leave_Tran_ID>> Handle(UpdateLeave_TransactionCommand request, CancellationToken cancellationToken)
        {

            IList<LeaveApproval_Leave_Tran_ID> result = await _procedureAdabter
                .Execute<LeaveApproval_Leave_Tran_ID>("[HRA].[proc_Leave_TransactionUpdate]", request);

            return result;
        }
    }
}
