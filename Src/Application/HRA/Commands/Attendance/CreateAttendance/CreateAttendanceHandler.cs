using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Attendance.CreateAttendance
{
    public class CreateAttendanceHandler : IRequestHandler<CreateAttendanceCommand, IList<Attendance_Attendance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateAttendanceHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Attendance_Attendance_ID>> Handle(CreateAttendanceCommand request, CancellationToken cancellationToken)
        {
            Guid? Attendance_ID = request.Attendance_ID;
            Guid? Att_OT_Trans_Id = request.Att_OT_Trans_Id;
            DateTime? Date = request.Date;
            string Employee_ID = request.Employee_ID;

            IList<Attendance_Attendance_ID> result = await _procedureAdabter
                .Execute<Attendance_Attendance_ID>("[HRA].[AttendanceInsert]",
                (nameof(Attendance_ID), Attendance_ID),
                (nameof(Att_OT_Trans_Id), Att_OT_Trans_Id),
                (nameof(Date), Date),
                (nameof(Employee_ID), Employee_ID));

            return result;
        }

    }
}
