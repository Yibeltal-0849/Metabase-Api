using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadAll
{
    class GetprocAttendanceLoadAllQueryHandler : IRequestHandler<GetprocAttendanceLoadAllQuery, GetprocAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAttendanceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAttendanceLoadAllListVm> Handle(GetprocAttendanceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Attendance> procAttendances = await _procedureAdabter
               .Execute<Attendance>("[HRA].[proc_AttendanceLoadAll]");
            GetprocAttendanceLoadAllListVm vm = new GetprocAttendanceLoadAllListVm
            {
                procAttendances = _mapper.Map<IList<Attendance>, IList<GetprocAttendanceLoadAllVm>>(procAttendances)
            };

            return vm;
        }
    }
}
