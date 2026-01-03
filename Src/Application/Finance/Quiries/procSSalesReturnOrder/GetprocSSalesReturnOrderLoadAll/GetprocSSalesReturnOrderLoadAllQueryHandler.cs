using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalesReturnOrder.GetprocSSalesReturnOrderLoadAll
{
    class GetprocSSalesReturnOrderLoadAllQueryHandler : IRequestHandler<GetprocSSalesReturnOrderLoadAllQuery, GetprocSSalesReturnOrderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSSalesReturnOrderLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalesReturnOrderLoadAllListVm> Handle(GetprocSSalesReturnOrderLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SSalesReturnOrder> procSSalesReturnOrders = await _procedureAdabter
               .Execute<SSalesReturnOrder>("[FINA].[proc_S_Sales_Return_OrderLoadAll]");
            GetprocSSalesReturnOrderLoadAllListVm vm = new GetprocSSalesReturnOrderLoadAllListVm
            {
                procSSalesReturnOrders = _mapper.Map<IList<SSalesReturnOrder>, IList<GetprocSSalesReturnOrderLoadAllVm>>(procSSalesReturnOrders)
            };

            return vm;
        }
    }
}
