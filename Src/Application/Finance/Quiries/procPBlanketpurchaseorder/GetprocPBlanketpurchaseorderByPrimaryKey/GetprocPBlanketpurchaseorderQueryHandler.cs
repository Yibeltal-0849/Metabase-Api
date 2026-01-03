using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPBlanketpurchaseorder.GetprocPBlanketpurchaseorderLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPBlanketpurchaseorder.GetprocPBlanketpurchaseorderByPrimaryKey
{
    public class GetprocPBlanketpurchaseorderQueryHandler : IRequestHandler<GetprocPBlanketpurchaseorderByPrimaryKey, GetprocPBlanketpurchaseorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPBlanketpurchaseorderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPBlanketpurchaseorderLoadAllListVm> Handle(GetprocPBlanketpurchaseorderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PBlanketPurchaseOrder> procPBlanketpurchaseorders = await _procedureAdabter
               .Execute<PBlanketPurchaseOrder>("[FINA].[proc_P_Blanket purchase orderLoadByPrimaryKey]", request);
            GetprocPBlanketpurchaseorderLoadAllListVm vm = new GetprocPBlanketpurchaseorderLoadAllListVm
            {
                procPBlanketpurchaseorders = _mapper.Map<IList<PBlanketPurchaseOrder>, IList<GetprocPBlanketpurchaseorderLoadAllVm>>(procPBlanketpurchaseorders)
            };

            return vm;
        }
    }
}
