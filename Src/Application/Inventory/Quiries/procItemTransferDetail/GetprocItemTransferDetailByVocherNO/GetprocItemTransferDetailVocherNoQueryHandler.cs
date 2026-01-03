using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procItemTransferDetail.GetprocItemTransferDetailLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Quiries.procItemTransferDetail.GetprocItemTransferDetailByVocherNO
{
    public class GetprocItemTransferDetailVocherNoQueryHandler : IRequestHandler<GetprocItemTransferDetailByVocherNo, GetprocItemTransferDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocItemTransferDetailVocherNoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemTransferDetailLoadAllListVm> Handle(GetprocItemTransferDetailByVocherNo request, CancellationToken cancellationToken)
        {

            IList<ItemTransferDetail> procItemTransferDetails = await _procedureAdabter
               .Execute<ItemTransferDetail>("[Inventory].[proc_Item_Transfer_DetailLoadByVocherNO]", request);
            GetprocItemTransferDetailLoadAllListVm vm = new GetprocItemTransferDetailLoadAllListVm
            {
                procItemTransferDetails = _mapper.Map<IList<ItemTransferDetail>, IList<GetprocItemTransferDetailLoadAllVm>>(procItemTransferDetails)
            };

            return vm;
        }
    }
}
