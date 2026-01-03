using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procPayrollAddition.GetprocPayrollAdditionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayrollAddition.GetprocPayrollAdditionByPrimaryKey
{
    public class GetprocPayrollAdditionQueryHandler : IRequestHandler<GetprocPayrollAdditionByPrimaryKey, GetprocPayrollAdditionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPayrollAdditionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayrollAdditionLoadAllListVm> Handle(GetprocPayrollAdditionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PayrollAddition> procPayrollAdditions = await _procedureAdabter
               .Execute<PayrollAddition>("[HRA].[proc_Payroll_AdditionLoadByPrimaryKey]", request);
            GetprocPayrollAdditionLoadAllListVm vm = new GetprocPayrollAdditionLoadAllListVm
            {
                procPayrollAdditions = _mapper.Map<IList<PayrollAddition>, IList<GetprocPayrollAdditionLoadAllVm>>(procPayrollAdditions)
            };

            return vm;
        }
    }
}
