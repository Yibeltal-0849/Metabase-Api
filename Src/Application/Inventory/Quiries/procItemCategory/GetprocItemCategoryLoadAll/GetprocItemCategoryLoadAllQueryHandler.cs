using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemCategory.GetprocItemCategoryLoadAll
{
    class GetprocItemCategoryLoadAllQueryHandler : IRequestHandler<GetprocItemCategoryLoadAllQuery, GetprocItemCategoryLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocItemCategoryLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemCategoryLoadAllListVm> Handle(GetprocItemCategoryLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Item_Category> procItemCategorys = await _procedureAdabter
               .Execute<Item_Category>("[Inventory].[proc_Item_CategoryLoadAll]");
            GetprocItemCategoryLoadAllListVm vm = new GetprocItemCategoryLoadAllListVm
            {
                procItemCategorys = _mapper.Map<IList<Item_Category>, IList<GetprocItemCategoryLoadAllVm>>(procItemCategorys)
            };

            return vm;
        }
    }
}
