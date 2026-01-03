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

namespace XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.Getproc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code
{
    public class GetAttendance_and_OT_TransactionQueryHandler : IRequestHandler<Getproc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code, GetAttendance_and_OT_TransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAttendance_and_OT_TransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetAttendance_and_OT_TransactionLoadAllListVm> Handle(Getproc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code request, CancellationToken cancellationToken)
        {
            Guid Application_Code = request.Application_Code;
            IList<AttendanceAndOtTransaction> Attendance_and_OT_Transactions = await _procedureAdabter
               .Execute<AttendanceAndOtTransaction>("[HRA].[proc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code]", (nameof(Application_Code), Application_Code));
            GetAttendance_and_OT_TransactionLoadAllListVm vm = new GetAttendance_and_OT_TransactionLoadAllListVm
            {
                Attendance_and_OT_Transactions = _mapper.Map<IList<AttendanceAndOtTransaction>, IList<GetAttendance_and_OT_TransactionLoadAllVm>>(Attendance_and_OT_Transactions)
            };

            return vm;
        }
    }
}
