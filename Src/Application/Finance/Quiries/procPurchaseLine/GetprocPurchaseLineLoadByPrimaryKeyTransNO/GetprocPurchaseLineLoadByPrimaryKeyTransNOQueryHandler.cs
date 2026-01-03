using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;
using Application.Finance.Quiries.procPurchaseLine;

namespace Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadByPrimaryKeyTransNO
{
    public class GetprocPurchaseLineLoadByPrimaryKeyTransNOQueryHandler : IRequestHandler<GetprocPurchaseLineLoadByPrimaryKeyTransNO, GetprocPurchaseLineLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPurchaseLineLoadByPrimaryKeyTransNOQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPurchaseLineLoadAllListVm> Handle(GetprocPurchaseLineLoadByPrimaryKeyTransNO request, CancellationToken cancellationToken)
        {
           
            IList<PurchaseLine> procPurchaseLineLoadByPrimaryKeyTransNOs = await _procedureAdabter
               .Execute<PurchaseLine>("[FINA].[proc_Purchase_LineLoadByPrimaryKey_Trans_NO]", request);
            GetprocPurchaseLineLoadAllListVm vm = new GetprocPurchaseLineLoadAllListVm
            {
                procPurchaseLines = _mapper.Map<IList<PurchaseLine>, IList<GetprocPurchaseLineLoadAllVm>>(procPurchaseLineLoadByPrimaryKeyTransNOs)
            };

            return vm;
        }
    }
}
