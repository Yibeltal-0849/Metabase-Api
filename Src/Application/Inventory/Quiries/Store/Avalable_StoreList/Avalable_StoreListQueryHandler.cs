using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;
using Application.Inventory.Quiries.Store.GetStoreLoadAll;
using Application.Inventory.Quiries.Store;

namespace Application.Inventory.Quiries.procTAXBusPostingGroup.Avalable_StoreList
{
    public class Avalable_StoreListQueryHandler : IRequestHandler<Avalable_StoreList, GetStoreLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Avalable_StoreListQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStoreLoadAllListVm> Handle(Avalable_StoreList request, CancellationToken cancellationToken)
        {
           
            IList<_Store> Stores = await _procedureAdabter
               .Execute<_Store>("[Inventory].[Avalable_StoreList]", request);
            GetStoreLoadAllListVm vm = new GetStoreLoadAllListVm
            {
                Stores = _mapper.Map<IList<_Store>, IList<GetStoreLoadAllVm>>(Stores)
            };

            return vm;
        }
    }
}
