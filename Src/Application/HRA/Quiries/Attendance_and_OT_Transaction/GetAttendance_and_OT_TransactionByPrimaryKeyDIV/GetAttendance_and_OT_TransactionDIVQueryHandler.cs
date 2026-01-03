using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionByPrimaryKeyDIV
{
    public class GetAttendance_and_OT_TransactionDIVQueryHandler : IRequestHandler<GetAttendance_and_OT_TransactionByPrimaryKeyDIV, GetAttendance_and_OT_TransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAttendance_and_OT_TransactionDIVQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetAttendance_and_OT_TransactionLoadAllListVm> Handle(GetAttendance_and_OT_TransactionByPrimaryKeyDIV request, CancellationToken cancellationToken)
        {
            Guid DIV = request.DIV;
            IList<AttendanceAndOtTransaction> Attendance_and_OT_Transactions = await _procedureAdabter
               .Execute<AttendanceAndOtTransaction>("[HRA].[proc_Attendance_and_OT_TransactionLoadByPrimaryKeyDIV]", (nameof(DIV), DIV));
            GetAttendance_and_OT_TransactionLoadAllListVm vm = new GetAttendance_and_OT_TransactionLoadAllListVm
            {
                Attendance_and_OT_Transactions = _mapper.Map<IList<AttendanceAndOtTransaction>, IList<GetAttendance_and_OT_TransactionLoadAllVm>>(Attendance_and_OT_Transactions)
            };

            return vm;
        }
    }
}
