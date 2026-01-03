using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemType.GetprocItemTypeLoadAll
{
    class GetprocItemTypeLoadAllQueryHandler : IRequestHandler<GetprocItemTypeLoadAllQuery, GetprocItemTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocItemTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemTypeLoadAllListVm> Handle(GetprocItemTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ItemType> procItemTypes = await _procedureAdabter
               .Execute<ItemType>("[Inventory].[proc_ItemTypeLoadAll]");
            GetprocItemTypeLoadAllListVm vm = new GetprocItemTypeLoadAllListVm
            {
                procItemTypes = _mapper.Map<IList<ItemType>, IList<GetprocItemTypeLoadAllVm>>(procItemTypes)
            };

            return vm;
        }
    }
}
