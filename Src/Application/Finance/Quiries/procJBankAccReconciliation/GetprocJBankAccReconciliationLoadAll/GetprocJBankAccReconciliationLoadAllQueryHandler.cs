using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJBankAccReconciliation.GetprocJBankAccReconciliationLoadAll
{
    class GetprocJBankAccReconciliationLoadAllQueryHandler : IRequestHandler<GetprocJBankAccReconciliationLoadAllQuery, GetprocJBankAccReconciliationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJBankAccReconciliationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJBankAccReconciliationLoadAllListVm> Handle(GetprocJBankAccReconciliationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JBankAccReconciliation> procJBankAccReconciliations = await _procedureAdabter
               .Execute<JBankAccReconciliation>("[FINA].[proc_J_Bank_Acc_ReconciliationLoadAll]");
            GetprocJBankAccReconciliationLoadAllListVm vm = new GetprocJBankAccReconciliationLoadAllListVm
            {
                procJBankAccReconciliations = _mapper.Map<IList<JBankAccReconciliation>, IList<GetprocJBankAccReconciliationLoadAllVm>>(procJBankAccReconciliations)
            };

            return vm;
        }
    }
}
