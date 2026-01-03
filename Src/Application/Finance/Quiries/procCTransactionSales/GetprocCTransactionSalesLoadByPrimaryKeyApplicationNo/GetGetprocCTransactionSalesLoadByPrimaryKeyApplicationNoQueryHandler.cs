using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCTransactionSales.GetprocCTransactionSalesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCTransactionSales.GetprocCTransactionSalesLoadByPrimaryKeyApplicationNo
{
    public class GetprocCTransactionSalesQueryHandler : IRequestHandler<GetprocCTransactionSalesLoadByPrimaryKeyApplicationNo, GetprocCTransactionSalesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCTransactionSalesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCTransactionSalesLoadAllListVm> Handle(GetprocCTransactionSalesLoadByPrimaryKeyApplicationNo request, CancellationToken cancellationToken)
        {
           
            IList<CTransactionSales> procCTransactionSaless = await _procedureAdabter
               .Execute<CTransactionSales>("[FINA].[proc_CTransaction_SalesLoadByPrimaryKey_Application_No]", request);
            GetprocCTransactionSalesLoadAllListVm vm = new GetprocCTransactionSalesLoadAllListVm
            {
                procCTransactionSaless = _mapper.Map<IList<CTransactionSales>, IList<GetprocCTransactionSalesLoadAllVm>>(procCTransactionSaless)
            };

            return vm;
        }
    }
}
