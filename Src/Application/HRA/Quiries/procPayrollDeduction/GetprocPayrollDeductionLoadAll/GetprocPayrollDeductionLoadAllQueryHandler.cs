using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayrollDeduction.GetprocPayrollDeductionLoadAll
{
    class GetprocPayrollDeductionLoadAllQueryHandler : IRequestHandler<GetprocPayrollDeductionLoadAllQuery, GetprocPayrollDeductionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPayrollDeductionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayrollDeductionLoadAllListVm> Handle(GetprocPayrollDeductionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PayrollDeduction> procPayrollDeductions = await _procedureAdabter
               .Execute<PayrollDeduction>("[HRA].[proc_Payroll_DeductionLoadAll]");
            GetprocPayrollDeductionLoadAllListVm vm = new GetprocPayrollDeductionLoadAllListVm
            {
                procPayrollDeductions = _mapper.Map<IList<PayrollDeduction>, IList<GetprocPayrollDeductionLoadAllVm>>(procPayrollDeductions)
            };

            return vm;
        }
    }
}
