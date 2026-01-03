using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceByPrimaryKey
{
    public class GetprocDailyAttendanceQueryHandler : IRequestHandler<GetprocDailyAttendanceByPrimaryKey, GetprocDailyAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocDailyAttendanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDailyAttendanceLoadAllListVm> Handle(GetprocDailyAttendanceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Daily_Attendance> procDailyAttendances = await _procedureAdabter
               .Execute<Daily_Attendance>("[HRA].[proc_Daily_AttendanceLoadByPrimaryKey]", request);
            GetprocDailyAttendanceLoadAllListVm vm = new GetprocDailyAttendanceLoadAllListVm
            {
                procDailyAttendances = _mapper.Map<IList<Daily_Attendance>, IList<GetprocDailyAttendanceLoadAllVm>>(procDailyAttendances)
            };

            return vm;
        }
    }
}
