using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSBlanketSalesorder.GetprocSBlanketSalesorderLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSBlanketSalesorder.GetprocSBlanketSalesorderByPrimaryKey
{
    public class GetprocSBlanketSalesorderQueryHandler : IRequestHandler<GetprocSBlanketSalesorderByPrimaryKey, GetprocSBlanketSalesorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSBlanketSalesorderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSBlanketSalesorderLoadAllListVm> Handle(GetprocSBlanketSalesorderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SBlanketSalesOrder> procSBlanketSalesorders = await _procedureAdabter
               .Execute<SBlanketSalesOrder>("[FINA].[proc_S_Blanket_Sales_orderLoadByPrimaryKey]", request);
            GetprocSBlanketSalesorderLoadAllListVm vm = new GetprocSBlanketSalesorderLoadAllListVm
            {
                procSBlanketSalesorders = _mapper.Map<IList<SBlanketSalesOrder>, IList<GetprocSBlanketSalesorderLoadAllVm>>(procSBlanketSalesorders)
            };

            return vm;
        }
    }
}
