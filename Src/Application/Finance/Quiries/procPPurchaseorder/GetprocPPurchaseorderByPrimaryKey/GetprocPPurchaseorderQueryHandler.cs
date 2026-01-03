using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPPurchaseorder.GetprocPPurchaseorderLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPPurchaseorder.GetprocPPurchaseorderByPrimaryKey
{
    public class GetprocPPurchaseorderQueryHandler : IRequestHandler<GetprocPPurchaseorderByPrimaryKey, GetprocPPurchaseorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPPurchaseorderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPPurchaseorderLoadAllListVm> Handle(GetprocPPurchaseorderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PPurchaseOrder> procPPurchaseorders = await _procedureAdabter
               .Execute<PPurchaseOrder>("[FINA].[proc_P_Purchase orderLoadByPrimaryKey]", request);
            GetprocPPurchaseorderLoadAllListVm vm = new GetprocPPurchaseorderLoadAllListVm
            {
                procPPurchaseorders = _mapper.Map<IList<PPurchaseOrder>, IList<GetprocPPurchaseorderLoadAllVm>>(procPPurchaseorders)
            };

            return vm;
        }
    }
}
