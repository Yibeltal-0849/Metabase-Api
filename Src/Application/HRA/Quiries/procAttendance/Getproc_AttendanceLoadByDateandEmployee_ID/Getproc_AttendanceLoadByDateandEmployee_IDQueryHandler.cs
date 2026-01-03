using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procAttendance.Getproc_AttendanceLoadByDateandEmployee_ID
{
    public class Getproc_AttendanceLoadByDateandEmployee_IDQueryHandler : IRequestHandler<Getproc_AttendanceLoadByDateandEmployee_ID, GetprocAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Getproc_AttendanceLoadByDateandEmployee_IDQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAttendanceLoadAllListVm> Handle(Getproc_AttendanceLoadByDateandEmployee_ID request, CancellationToken cancellationToken)
        {
           
            IList<Attendance> procAttendances = await _procedureAdabter
               .Execute<Attendance>("[HRA].[proc_AttendanceLoadByDateandEmployee_ID]", request);
            GetprocAttendanceLoadAllListVm vm = new GetprocAttendanceLoadAllListVm
            {
                procAttendances = _mapper.Map<IList<Attendance>, IList<GetprocAttendanceLoadAllVm>>(procAttendances)
            };

            return vm;
        }
    }
}
