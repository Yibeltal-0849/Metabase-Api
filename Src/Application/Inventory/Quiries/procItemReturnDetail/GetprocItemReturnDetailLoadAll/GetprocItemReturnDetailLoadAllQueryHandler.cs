using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemReturnDetail.GetprocItemReturnDetailLoadAll
{
    class GetprocItemReturnDetailLoadAllQueryHandler : IRequestHandler<GetprocItemReturnDetailLoadAllQuery, GetprocItemReturnDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocItemReturnDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemReturnDetailLoadAllListVm> Handle(GetprocItemReturnDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ItemReturnDetail> procItemReturnDetails = await _procedureAdabter
               .Execute<ItemReturnDetail>("[Inventory].[proc_Item_Return_DetailLoadAll]");
            GetprocItemReturnDetailLoadAllListVm vm = new GetprocItemReturnDetailLoadAllListVm
            {
                procItemReturnDetails = _mapper.Map<IList<ItemReturnDetail>, IList<GetprocItemReturnDetailLoadAllVm>>(procItemReturnDetails)
            };

            return vm;
        }
    }
}
