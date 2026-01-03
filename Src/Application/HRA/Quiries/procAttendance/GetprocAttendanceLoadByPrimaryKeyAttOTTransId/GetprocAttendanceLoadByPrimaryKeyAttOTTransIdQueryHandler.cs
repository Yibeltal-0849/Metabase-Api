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

namespace Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadByPrimaryKeyAttOTTransId
{
    public class GetprocAttendanceQueryHandler : IRequestHandler<GetprocAttendanceLoadByPrimaryKeyAttOTTransId, GetprocAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAttendanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAttendanceLoadAllListVm> Handle(GetprocAttendanceLoadByPrimaryKeyAttOTTransId request, CancellationToken cancellationToken)
        {
           
            IList<Attendance> procAttendances = await _procedureAdabter
               .Execute<Attendance>("[HRA].[proc_AttendanceLoadByPrimaryKey_Att_OT_Trans_Id]", request);
            GetprocAttendanceLoadAllListVm vm = new GetprocAttendanceLoadAllListVm
            {
                procAttendances = _mapper.Map<IList<Attendance>, IList<GetprocAttendanceLoadAllVm>>(procAttendances)
            };

            return vm;
        }
    }
}
