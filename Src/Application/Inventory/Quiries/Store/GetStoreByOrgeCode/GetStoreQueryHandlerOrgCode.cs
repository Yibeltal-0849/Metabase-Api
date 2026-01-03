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


namespace Application.Inventory.Quiries.Store.GetStoreByOrgeCode
{
    public class GetStoreQueryHandlerOrgCode : IRequestHandler<GetStoreByCorgCode, GetStoreLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetStoreQueryHandlerOrgCode(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStoreLoadAllListVm> Handle(GetStoreByCorgCode request, CancellationToken cancellationToken)
        {

            IList<_Store> Stores = await _procedureAdabter
               .Execute<_Store>("[Inventory].[proc_StoreLoadByOrgCode]", request);
            GetStoreLoadAllListVm vm = new GetStoreLoadAllListVm
            {
                Stores = _mapper.Map<IList<_Store>, IList<GetStoreLoadAllVm>>(Stores)
            };

            return vm;
        }
    }
}
