using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayrollAddition.GetprocPayrollAdditionLoadAll
{
    class GetprocPayrollAdditionLoadAllQueryHandler : IRequestHandler<GetprocPayrollAdditionLoadAllQuery, GetprocPayrollAdditionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPayrollAdditionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayrollAdditionLoadAllListVm> Handle(GetprocPayrollAdditionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PayrollAddition> procPayrollAdditions = await _procedureAdabter
               .Execute<PayrollAddition>("[HRA].[proc_Payroll_AdditionLoadAll]");
            GetprocPayrollAdditionLoadAllListVm vm = new GetprocPayrollAdditionLoadAllListVm
            {
                procPayrollAdditions = _mapper.Map<IList<PayrollAddition>, IList<GetprocPayrollAdditionLoadAllVm>>(procPayrollAdditions)
            };

            return vm;
        }
    }
}
