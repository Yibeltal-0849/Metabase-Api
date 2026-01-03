using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Leave.UpdateLeave
{
    public class UpdateLeaveHandler : IRequestHandler<UpdateLeaveCommand, IList<Leave_Leave_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateLeaveHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Leave_Leave_ID>> Handle(UpdateLeaveCommand request, CancellationToken cancellationToken)
        {

            IList<Leave_Leave_ID> result = await _procedureAdabter
               .Execute<Leave_Leave_ID>("[HRA].[proc_LeaveUpdate]", request);

            return result;
        }
    }
}
