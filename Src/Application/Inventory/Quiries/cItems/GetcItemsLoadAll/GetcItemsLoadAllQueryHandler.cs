using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.cItems.GetcItemsLoadAll
{
    class GetcItemsLoadAllQueryHandler : IRequestHandler<GetcItemsLoadAllQuery, GetcItemsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetcItemsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetcItemsLoadAllListVm> Handle(GetcItemsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<C_Items> cItemss = await _procedureAdabter
               .Execute<C_Items>("[Inventory].[proc_c_ItemsLoadAll]");
            GetcItemsLoadAllListVm vm = new GetcItemsLoadAllListVm
            {
                cItemss = _mapper.Map<IList<C_Items>, IList<GetcItemsLoadAllVm>>(cItemss)
            };

            return vm;
        }
    }
}
