using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procItemTransferDetail.GetprocItemTransferDetailLoadAll
{
    class GetprocItemTransferDetailLoadAllQueryHandler : IRequestHandler<GetprocItemTransferDetailLoadAllQuery, GetprocItemTransferDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocItemTransferDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemTransferDetailLoadAllListVm> Handle(GetprocItemTransferDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ItemTransferDetail> procItemTransferDetails = await _procedureAdabter
               .Execute<ItemTransferDetail>("[FINA].[proc_Item_Transfer_DetailLoadAll]");
            GetprocItemTransferDetailLoadAllListVm vm = new GetprocItemTransferDetailLoadAllListVm
            {
                procItemTransferDetails = _mapper.Map<IList<ItemTransferDetail>, IList<GetprocItemTransferDetailLoadAllVm>>(procItemTransferDetails)
            };

            return vm;
        }
    }
}
