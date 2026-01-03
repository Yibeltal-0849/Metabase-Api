using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procPayrollDeduction.GetprocPayrollDeductionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayrollDeduction.GetprocPayrollDeductionByPrimaryKey
{
    public class GetprocPayrollDeductionQueryHandler : IRequestHandler<GetprocPayrollDeductionByPrimaryKey, GetprocPayrollDeductionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPayrollDeductionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayrollDeductionLoadAllListVm> Handle(GetprocPayrollDeductionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PayrollDeduction> procPayrollDeductions = await _procedureAdabter
               .Execute<PayrollDeduction>("[HRA].[proc_Payroll_DeductionLoadByPrimaryKey]", request);
            GetprocPayrollDeductionLoadAllListVm vm = new GetprocPayrollDeductionLoadAllListVm
            {
                procPayrollDeductions = _mapper.Map<IList<PayrollDeduction>, IList<GetprocPayrollDeductionLoadAllVm>>(procPayrollDeductions)
            };

            return vm;
        }
    }
}
