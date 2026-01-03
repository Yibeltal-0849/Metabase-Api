using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayrollAdditionType.GetprocPayrollAdditionTypeByPrimaryKey
{
    public class GetprocPayrollAdditionTypeQueryHandler : IRequestHandler<GetprocPayrollAdditionTypeByPrimaryKey, GetprocPayrollAdditionTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPayrollAdditionTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayrollAdditionTypeLoadAllListVm> Handle(GetprocPayrollAdditionTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PayrollAdditionType> procPayrollAdditionTypes = await _procedureAdabter
               .Execute<PayrollAdditionType>("[HRA].[proc_Payroll_Addition_TypeLoadByPrimaryKey]", request);
            GetprocPayrollAdditionTypeLoadAllListVm vm = new GetprocPayrollAdditionTypeLoadAllListVm
            {
                procPayrollAdditionTypes = _mapper.Map<IList<PayrollAdditionType>, IList<GetprocPayrollAdditionTypeLoadAllVm>>(procPayrollAdditionTypes)
            };

            return vm;
        }
    }
}
