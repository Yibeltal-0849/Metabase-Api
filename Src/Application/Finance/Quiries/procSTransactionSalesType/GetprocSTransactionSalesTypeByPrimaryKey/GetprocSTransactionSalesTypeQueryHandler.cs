using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSTransactionSalesType.GetprocSTransactionSalesTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSTransactionSalesType.GetprocSTransactionSalesTypeByPrimaryKey
{
    public class GetprocSTransactionSalesTypeQueryHandler : IRequestHandler<GetprocSTransactionSalesTypeByPrimaryKey, GetprocSTransactionSalesTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSTransactionSalesTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSTransactionSalesTypeLoadAllListVm> Handle(GetprocSTransactionSalesTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<STransactionSalesType> procSTransactionSalesTypes = await _procedureAdabter
               .Execute<STransactionSalesType>("[FINA].[proc_S_Transaction Sales_TypeLoadByPrimaryKey]", request);
            GetprocSTransactionSalesTypeLoadAllListVm vm = new GetprocSTransactionSalesTypeLoadAllListVm
            {
                procSTransactionSalesTypes = _mapper.Map<IList<STransactionSalesType>, IList<GetprocSTransactionSalesTypeLoadAllVm>>(procSTransactionSalesTypes)
            };

            return vm;
        }
    }
}
