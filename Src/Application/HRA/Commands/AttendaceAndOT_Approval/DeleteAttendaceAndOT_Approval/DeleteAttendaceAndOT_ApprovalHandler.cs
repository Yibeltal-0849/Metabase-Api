using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.AttendaceAndOT_Approval.DeleteAttendaceAndOT_Approval
{
    public class DeleteAttendaceAndOT_ApprovalHandler : IRequestHandler<DeleteAttendaceAndOT_ApprovalCommand, IList<AttendaceAndOtApproval_ATT_OT_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteAttendaceAndOT_ApprovalHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AttendaceAndOtApproval_ATT_OT_Trans_ID>> Handle(DeleteAttendaceAndOT_ApprovalCommand request, CancellationToken cancellationToken)
        {
            Guid? ATT_OT_Trans_ID = request.ATT_OT_Trans_ID;
            IList<AttendaceAndOtApproval_ATT_OT_Trans_ID> result = await _procedureAdabter
                .Execute<AttendaceAndOtApproval_ATT_OT_Trans_ID>("[HRA].[AttendaceAndOT_ApprovalDelete]", (nameof(ATT_OT_Trans_ID), ATT_OT_Trans_ID));

            return result;
        }
    }
}
