using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Attendance.DeleteAttendance
{
    public class DeleteAttendanceHandler : IRequestHandler<DeleteAttendanceCommand, IList<Attendance_Attendance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteAttendanceHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Attendance_Attendance_ID>> Handle(DeleteAttendanceCommand request, CancellationToken cancellationToken)
        {
            Guid Attendance_ID = request.Attendance_ID;
            IList<Attendance_Attendance_ID> result = await _procedureAdabter
                .Execute<Attendance_Attendance_ID>("[HRA].[AttendanceDelete]",
                (nameof(Attendance_ID), Attendance_ID));

            return result;
        }
    }
}
