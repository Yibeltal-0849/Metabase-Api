using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJBankReconTransaction.GetprocJBankReconTransactionLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJBankReconTransaction.GetprocJBankReconTransactionByPrimaryKey
{
    public class GetprocJBankReconTransactionQueryHandler : IRequestHandler<GetprocJBankReconTransactionByPrimaryKey, GetprocJBankReconTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJBankReconTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJBankReconTransactionLoadAllListVm> Handle(GetprocJBankReconTransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JBankReconTransaction> procJBankReconTransactions = await _procedureAdabter
               .Execute<JBankReconTransaction>("[FINA].[proc_J_Bank_Recon_TransactionLoadByPrimaryKey]", request);
            GetprocJBankReconTransactionLoadAllListVm vm = new GetprocJBankReconTransactionLoadAllListVm
            {
                procJBankReconTransactions = _mapper.Map<IList<JBankReconTransaction>, IList<GetprocJBankReconTransactionLoadAllVm>>(procJBankReconTransactions)
            };

            return vm;
        }
    }
}
