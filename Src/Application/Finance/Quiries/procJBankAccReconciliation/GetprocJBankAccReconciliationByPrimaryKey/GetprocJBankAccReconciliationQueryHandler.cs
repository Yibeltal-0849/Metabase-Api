using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJBankAccReconciliation.GetprocJBankAccReconciliationLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJBankAccReconciliation.GetprocJBankAccReconciliationByPrimaryKey
{
    public class GetprocJBankAccReconciliationQueryHandler : IRequestHandler<GetprocJBankAccReconciliationByPrimaryKey, GetprocJBankAccReconciliationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJBankAccReconciliationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJBankAccReconciliationLoadAllListVm> Handle(GetprocJBankAccReconciliationByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JBankAccReconciliation> procJBankAccReconciliations = await _procedureAdabter
               .Execute<JBankAccReconciliation>("[FINA].[proc_J_Bank_Acc_ReconciliationLoadByPrimaryKey]", request);
            GetprocJBankAccReconciliationLoadAllListVm vm = new GetprocJBankAccReconciliationLoadAllListVm
            {
                procJBankAccReconciliations = _mapper.Map<IList<JBankAccReconciliation>, IList<GetprocJBankAccReconciliationLoadAllVm>>(procJBankAccReconciliations)
            };

            return vm;
        }
    }
}
