using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procInventoryPostingGroup.GetprocInventoryPostingGroupLoadAll
{
    class GetprocInventoryPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocInventoryPostingGroupLoadAllQuery, GetprocInventoryPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocInventoryPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocInventoryPostingGroupLoadAllListVm> Handle(GetprocInventoryPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<InventoryPostingGroup> procInventoryPostingGroups = await _procedureAdabter
               .Execute<InventoryPostingGroup>("[Inventory].[proc_Inventory_Posting_GroupLoadAll]");
            GetprocInventoryPostingGroupLoadAllListVm vm = new GetprocInventoryPostingGroupLoadAllListVm
            {
                procInventoryPostingGroups = _mapper.Map<IList<InventoryPostingGroup>, IList<GetprocInventoryPostingGroupLoadAllVm>>(procInventoryPostingGroups)
            };

            return vm;
        }
    }
}
