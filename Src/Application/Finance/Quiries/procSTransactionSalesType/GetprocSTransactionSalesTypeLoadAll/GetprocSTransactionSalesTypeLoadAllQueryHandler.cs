using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSTransactionSalesType.GetprocSTransactionSalesTypeLoadAll
{
    class GetprocSTransactionSalesTypeLoadAllQueryHandler : IRequestHandler<GetprocSTransactionSalesTypeLoadAllQuery, GetprocSTransactionSalesTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSTransactionSalesTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSTransactionSalesTypeLoadAllListVm> Handle(GetprocSTransactionSalesTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<STransactionSalesType> procSTransactionSalesTypes = await _procedureAdabter
               .Execute<STransactionSalesType>("[FINA].[proc_S_Transaction Sales_TypeLoadAll]");
            GetprocSTransactionSalesTypeLoadAllListVm vm = new GetprocSTransactionSalesTypeLoadAllListVm
            {
                procSTransactionSalesTypes = _mapper.Map<IList<STransactionSalesType>, IList<GetprocSTransactionSalesTypeLoadAllVm>>(procSTransactionSalesTypes)
            };

            return vm;
        }
    }
}
