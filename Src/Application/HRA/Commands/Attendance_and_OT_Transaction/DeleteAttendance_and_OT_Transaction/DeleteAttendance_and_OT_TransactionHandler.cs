using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Attendance_and_OT_Transaction.DeleteAttendance_and_OT_Transaction
{
    public class DeleteAttendance_and_OT_TransactionHandler : IRequestHandler<DeleteAttendance_and_OT_TransactionCommand, IList<AttendanceAndOtTransaction_Att_OT_Trans_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteAttendance_and_OT_TransactionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AttendanceAndOtTransaction_Att_OT_Trans_Id>> Handle(DeleteAttendance_and_OT_TransactionCommand request, CancellationToken cancellationToken)
        {
            Guid Att_OT_Trans_Id = request.Att_OT_Trans_Id;
            IList<AttendanceAndOtTransaction_Att_OT_Trans_Id> result = await _procedureAdabter
                .Execute<AttendanceAndOtTransaction_Att_OT_Trans_Id>("[HRA].[Attendance_and_OT_TransactionDelete]",
                (nameof(Att_OT_Trans_Id), Att_OT_Trans_Id));

            return result;
        }
    }
}
