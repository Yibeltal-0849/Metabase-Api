using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Daily_Attendance.UpdateDaily_AttendanceExcel
{
    public class UpdateDaily_AttendanceExcelHandler : IRequestHandler<UpdateDaily_AttendanceExcelCommand, IList<DailyAttendance_Deily_Attemdance_IDExcel>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateDaily_AttendanceExcelHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DailyAttendance_Deily_Attemdance_IDExcel>> Handle(UpdateDaily_AttendanceExcelCommand request, CancellationToken cancellationToken)
        {

            IList<DailyAttendance_Deily_Attemdance_IDExcel> result = await _procedureAdabter
                .Execute<DailyAttendance_Deily_Attemdance_IDExcel>("[HRA].[Daily_AttendanceUpdatefromExcel]", request);

            return result;
        }
    }
}
