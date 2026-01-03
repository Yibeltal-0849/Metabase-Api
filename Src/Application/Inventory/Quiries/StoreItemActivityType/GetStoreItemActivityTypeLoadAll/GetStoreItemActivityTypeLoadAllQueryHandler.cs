using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeLoadAll
{
    class GetStoreItemActivityTypeLoadAllQueryHandler : IRequestHandler<GetStoreItemActivityTypeLoadAllQuery, GetStoreItemActivityTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetStoreItemActivityTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStoreItemActivityTypeLoadAllListVm> Handle(GetStoreItemActivityTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Store_Item_Activity_Type> StoreItemActivityTypes = await _procedureAdabter
               .Execute<Store_Item_Activity_Type>("[Inventory].[proc_Store_Item_Activity_TypeLoadAll]");
            GetStoreItemActivityTypeLoadAllListVm vm = new GetStoreItemActivityTypeLoadAllListVm
            {
                StoreItemActivityTypes = _mapper.Map<IList<Store_Item_Activity_Type>, IList<GetStoreItemActivityTypeLoadAllVm>>(StoreItemActivityTypes)
            };

            return vm;
        }
    }
}
