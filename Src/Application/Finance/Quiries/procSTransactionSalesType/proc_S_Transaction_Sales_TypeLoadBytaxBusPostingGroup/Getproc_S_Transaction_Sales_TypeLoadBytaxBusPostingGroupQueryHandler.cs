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

namespace Application.Finance.Quiries.procSTransactionSalesType.proc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroup
{
    public class Getproc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroupQueryHandler : IRequestHandler<proc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroup, GetprocSTransactionSalesTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Getproc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSTransactionSalesTypeLoadAllListVm> Handle(proc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroup request, CancellationToken cancellationToken)
        {
           
            IList<STransactionSalesType> procSTransactionSalesTypes = await _procedureAdabter
               .Execute<STransactionSalesType>("[FINA].[proc_S_Transaction Sales_TypeLoadBytaxBusPostingGroup]", request);
            GetprocSTransactionSalesTypeLoadAllListVm vm = new GetprocSTransactionSalesTypeLoadAllListVm
            {
                procSTransactionSalesTypes = _mapper.Map<IList<STransactionSalesType>, IList<GetprocSTransactionSalesTypeLoadAllVm>>(procSTransactionSalesTypes)
            };

            return vm;
        }
    }
}
