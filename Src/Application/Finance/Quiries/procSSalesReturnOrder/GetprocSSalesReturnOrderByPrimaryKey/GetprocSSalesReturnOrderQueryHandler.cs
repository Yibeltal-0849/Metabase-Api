using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSSalesReturnOrder.GetprocSSalesReturnOrderLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalesReturnOrder.GetprocSSalesReturnOrderByPrimaryKey
{
    public class GetprocSSalesReturnOrderQueryHandler : IRequestHandler<GetprocSSalesReturnOrderByPrimaryKey, GetprocSSalesReturnOrderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSSalesReturnOrderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalesReturnOrderLoadAllListVm> Handle(GetprocSSalesReturnOrderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SSalesReturnOrder> procSSalesReturnOrders = await _procedureAdabter
               .Execute<SSalesReturnOrder>("[FINA].[proc_S_Sales_Return_OrderLoadByPrimaryKey]", request);
            GetprocSSalesReturnOrderLoadAllListVm vm = new GetprocSSalesReturnOrderLoadAllListVm
            {
                procSSalesReturnOrders = _mapper.Map<IList<SSalesReturnOrder>, IList<GetprocSSalesReturnOrderLoadAllVm>>(procSSalesReturnOrders)
            };

            return vm;
        }
    }
}
