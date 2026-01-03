using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.Store.GetStoreLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.Store.GetStoreByPrimaryKey
{
    public class GetStoreQueryHandler : IRequestHandler<GetStoreByPrimaryKey, GetStoreLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetStoreQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStoreLoadAllListVm> Handle(GetStoreByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_Store> Stores = await _procedureAdabter
               .Execute<_Store>("[Inventory].[proc_StoreLoadByPrimaryKey]", request);
            GetStoreLoadAllListVm vm = new GetStoreLoadAllListVm
            {
                Stores = _mapper.Map<IList<_Store>, IList<GetStoreLoadAllVm>>(Stores)
            };

            return vm;
        }
    }
}
