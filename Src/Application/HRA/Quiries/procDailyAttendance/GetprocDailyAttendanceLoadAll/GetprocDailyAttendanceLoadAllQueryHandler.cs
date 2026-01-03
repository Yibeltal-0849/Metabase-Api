using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceLoadAll
{
    class GetprocDailyAttendanceLoadAllQueryHandler : IRequestHandler<GetprocDailyAttendanceLoadAllQuery, GetprocDailyAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDailyAttendanceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDailyAttendanceLoadAllListVm> Handle(GetprocDailyAttendanceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Daily_Attendance> procDailyAttendances = await _procedureAdabter
               .Execute<Daily_Attendance>("[HRA].[proc_Daily_AttendanceLoadAll]");
            GetprocDailyAttendanceLoadAllListVm vm = new GetprocDailyAttendanceLoadAllListVm
            {
                procDailyAttendances = _mapper.Map<IList<Daily_Attendance>, IList<GetprocDailyAttendanceLoadAllVm>>(procDailyAttendances)
            };

            return vm;
        }
    }
}
