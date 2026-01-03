using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcInventoryPostingGroup.GetProcInventoryPostingGroupLoadAll
{
    class GetProcInventoryPostingGroupLoadAllQueryHandler : IRequestHandler<GetProcInventoryPostingGroupLoadAllQuery, GetProcInventoryPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcInventoryPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcInventoryPostingGroupLoadAllListVm> Handle(GetProcInventoryPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<InventoryPostingGroup> ProcInventoryPostingGroups = await _procedureAdabter
               .Execute<InventoryPostingGroup>("[FINA].[proc_Inventory_Posting_GroupLoadAll]");
            GetProcInventoryPostingGroupLoadAllListVm vm = new GetProcInventoryPostingGroupLoadAllListVm
            {
                ProcInventoryPostingGroups = _mapper.Map<IList<InventoryPostingGroup>, IList<GetProcInventoryPostingGroupLoadAllVm>>(ProcInventoryPostingGroups)
            };

            return vm;
        }
    }
}
