using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Daily_Attendance.UpdateDaily_Attendance
{
    public class UpdateDaily_AttendanceHandler : IRequestHandler<UpdateDaily_AttendanceCommand, IList<DailyAttendance_Deily_Attemdance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateDaily_AttendanceHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DailyAttendance_Deily_Attemdance_ID>> Handle(UpdateDaily_AttendanceCommand request, CancellationToken cancellationToken)
        {

            IList<DailyAttendance_Deily_Attemdance_ID> result = await _procedureAdabter
                .Execute<DailyAttendance_Deily_Attemdance_ID>("[HRA].[Daily_AttendanceUpdate]", request);

            return result;
        }
    }
}
