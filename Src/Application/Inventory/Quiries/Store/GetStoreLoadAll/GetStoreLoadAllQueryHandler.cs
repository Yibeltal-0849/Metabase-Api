using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.Store.GetStoreLoadAll
{
    class GetStoreLoadAllQueryHandler : IRequestHandler<GetStoreLoadAllQuery, GetStoreLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetStoreLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStoreLoadAllListVm> Handle(GetStoreLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Store> Stores = await _procedureAdabter
               .Execute<_Store>("[Inventory].[proc_StoreLoadAll]");
            GetStoreLoadAllListVm vm = new GetStoreLoadAllListVm
            {
                Stores = _mapper.Map<IList<_Store>, IList<GetStoreLoadAllVm>>(Stores)
            };

            return vm;
        }
    }
}
