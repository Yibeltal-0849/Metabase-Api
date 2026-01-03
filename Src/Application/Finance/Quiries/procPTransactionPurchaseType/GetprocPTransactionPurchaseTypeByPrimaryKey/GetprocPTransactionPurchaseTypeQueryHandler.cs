using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPTransactionPurchaseType.GetprocPTransactionPurchaseTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPTransactionPurchaseType.GetprocPTransactionPurchaseTypeByPrimaryKey
{
    public class GetprocPTransactionPurchaseTypeQueryHandler : IRequestHandler<GetprocPTransactionPurchaseTypeByPrimaryKey, GetprocPTransactionPurchaseTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPTransactionPurchaseTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPTransactionPurchaseTypeLoadAllListVm> Handle(GetprocPTransactionPurchaseTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PTransactionPurchaseType> procPTransactionPurchaseTypes = await _procedureAdabter
               .Execute<PTransactionPurchaseType>("[FINA].[proc_P_Transaction Purchase TypeLoadByPrimaryKey]", request);
            GetprocPTransactionPurchaseTypeLoadAllListVm vm = new GetprocPTransactionPurchaseTypeLoadAllListVm
            {
                procPTransactionPurchaseTypes = _mapper.Map<IList<PTransactionPurchaseType>, IList<GetprocPTransactionPurchaseTypeLoadAllVm>>(procPTransactionPurchaseTypes)
            };

            return vm;
        }
    }
}
