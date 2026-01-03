using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.cItems.GetcItemsLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.cItems.GetcItemsByPrimaryKey
{
    public class GetcItemsQueryHandler : IRequestHandler<GetcItemsByPrimaryKey, GetcItemsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetcItemsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetcItemsLoadAllListVm> Handle(GetcItemsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<C_Items> cItemss = await _procedureAdabter
               .Execute<C_Items>("[Inventory].[proc_c_ItemsLoadByPrimaryKey]", request);
            GetcItemsLoadAllListVm vm = new GetcItemsLoadAllListVm
            {
                cItemss = _mapper.Map<IList<C_Items>, IList<GetcItemsLoadAllVm>>(cItemss)
            };

            return vm;
        }
    }
}
