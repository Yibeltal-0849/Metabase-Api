using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Attendance_and_OT_Transaction.UpdateAttendance_and_OT_Transaction
{
    public class UpdateAttendance_and_OT_TransactionHandler : IRequestHandler<UpdateAttendance_and_OT_TransactionCommand, IList<AttendanceAndOtTransaction_Att_OT_Trans_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateAttendance_and_OT_TransactionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AttendanceAndOtTransaction_Att_OT_Trans_Id>> Handle(UpdateAttendance_and_OT_TransactionCommand request, CancellationToken cancellationToken)
        {

            IList<AttendanceAndOtTransaction_Att_OT_Trans_Id> result = await _procedureAdabter
                .Execute<AttendanceAndOtTransaction_Att_OT_Trans_Id>("[HRA].[Attendance_and_OT_TransactionUpdate]", request);

            return result;
        }
    }
}
