using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionByPrimaryKey
{
    public class GetprocFixedAssetManagementTransactionQueryHandler : IRequestHandler<GetprocFixedAssetManagementTransactionByPrimaryKey, GetprocFixedAssetManagementTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetManagementTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetManagementTransactionLoadAllListVm> Handle(GetprocFixedAssetManagementTransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetManagementTransaction> procFixedAssetManagementTransactions = await _procedureAdabter
               .Execute<FixedAssetManagementTransaction>("[FINA].[proc_Fixed_Asset_Management_TransactionLoadByPrimaryKey]", request);
            GetprocFixedAssetManagementTransactionLoadAllListVm vm = new GetprocFixedAssetManagementTransactionLoadAllListVm
            {
                procFixedAssetManagementTransactions = _mapper.Map<IList<FixedAssetManagementTransaction>, IList<GetprocFixedAssetManagementTransactionLoadAllVm>>(procFixedAssetManagementTransactions)
            };

            return vm;
        }
    }
}
