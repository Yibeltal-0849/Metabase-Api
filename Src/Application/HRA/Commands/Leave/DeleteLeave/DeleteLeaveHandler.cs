using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Leave.DeleteLeave
{
    public class DeleteLeaveHandler : IRequestHandler<DeleteLeaveCommand, IList<Leave_Leave_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteLeaveHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Leave_Leave_ID>> Handle(DeleteLeaveCommand request, CancellationToken cancellationToken)
        {
            Guid Leave_ID = request.Leave_ID;
            IList<Leave_Leave_ID> result = await _procedureAdabter
                .Execute<Leave_Leave_ID>("[HRA].[proc_LeaveDelete]",
                (nameof(Leave_ID), Leave_ID));

            return result;
        }
    }
}
