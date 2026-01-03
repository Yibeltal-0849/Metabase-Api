using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.AttendaceAndOT_Approval.CreateAttendaceAndOT_Approval
{
    public class CreateAttendaceAndOT_ApprovalHandler : IRequestHandler<CreateAttendaceAndOT_ApprovalCommand, IList<AttendaceAndOtApproval_ATT_OT_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateAttendaceAndOT_ApprovalHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AttendaceAndOtApproval_ATT_OT_Trans_ID>> Handle(CreateAttendaceAndOT_ApprovalCommand request, CancellationToken cancellationToken)
        {

            IList<AttendaceAndOtApproval_ATT_OT_Trans_ID> result = await _procedureAdabter
                .Execute<AttendaceAndOtApproval_ATT_OT_Trans_ID>("[HRA].[AttendaceAndOT_ApprovalInsert]", request);

            return result;
        }

    }
}
