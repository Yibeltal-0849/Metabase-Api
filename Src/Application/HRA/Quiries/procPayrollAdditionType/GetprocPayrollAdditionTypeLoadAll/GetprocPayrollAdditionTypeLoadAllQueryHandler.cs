using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeLoadAll
{
    class GetprocPayrollAdditionTypeLoadAllQueryHandler : IRequestHandler<GetprocPayrollAdditionTypeLoadAllQuery, GetprocPayrollAdditionTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPayrollAdditionTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayrollAdditionTypeLoadAllListVm> Handle(GetprocPayrollAdditionTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PayrollAdditionType> procPayrollAdditionTypes = await _procedureAdabter
               .Execute<PayrollAdditionType>("[HRA].[proc_Payroll_Addition_TypeLoadAll]");
            GetprocPayrollAdditionTypeLoadAllListVm vm = new GetprocPayrollAdditionTypeLoadAllListVm
            {
                procPayrollAdditionTypes = _mapper.Map<IList<PayrollAdditionType>, IList<GetprocPayrollAdditionTypeLoadAllVm>>(procPayrollAdditionTypes)
            };

            return vm;
        }
    }
}
