using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Daily_Attendance.DeleteDaily_Attendance
{
    public class DeleteDaily_AttendanceHandler : IRequestHandler<DeleteDaily_AttendanceCommand, IList<DailyAttendance_Deily_Attemdance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteDaily_AttendanceHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DailyAttendance_Deily_Attemdance_ID>> Handle(DeleteDaily_AttendanceCommand request, CancellationToken cancellationToken)
        {
            Guid? Deily_Attemdance_ID = request.Deily_Attemdance_ID;
            IList<DailyAttendance_Deily_Attemdance_ID> result = await _procedureAdabter
                .Execute<DailyAttendance_Deily_Attemdance_ID>("[HRA].[Daily_AttendanceDelete]",
                (nameof(Deily_Attemdance_ID), Deily_Attemdance_ID));

            return result;
        }
    }
}
