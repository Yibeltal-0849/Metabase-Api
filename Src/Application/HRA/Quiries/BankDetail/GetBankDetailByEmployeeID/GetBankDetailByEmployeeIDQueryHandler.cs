using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionByPrimaryKeyDIV;
using XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.BankDetail
{
    public class GetBankDetailByEmployeeIDQueryHandler : IRequestHandler<GetBankDetailByEmployeeID, GetBankDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBankDetailByEmployeeIDQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBankDetailLoadAllListVm>Handle(GetBankDetailByEmployeeID request, CancellationToken cancellationToken)
        {
            string Employee_Id = request.Employee_Id;
            IList<bankDetail> BankDetails = await _procedureAdabter
               .Execute<bankDetail>("[HRA].[proc_GetBankDetailEmployee_Id]", (nameof(Employee_Id), Employee_Id));
          GetBankDetailLoadAllListVm vm = new GetBankDetailLoadAllListVm
            {
                BankDetails = _mapper.Map<IList<bankDetail>, IList<GetBankDetailLoadAllVm>>(BankDetails)
            };

            return vm;
        }
    }
}
