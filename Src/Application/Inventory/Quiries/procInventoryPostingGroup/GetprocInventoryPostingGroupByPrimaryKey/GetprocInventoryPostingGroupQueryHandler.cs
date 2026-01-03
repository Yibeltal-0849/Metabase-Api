using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procInventoryPostingGroup.GetprocInventoryPostingGroupLoadAll;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Inventory.Quiries.procInventoryPostingGroup.GetprocInventoryPostingGroupByPrimaryKey
{
    public class GetprocInventoryPostingGroupQueryHandler : IRequestHandler<GetprocInventoryPostingGroupByPrimaryKey, GetprocInventoryPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocInventoryPostingGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocInventoryPostingGroupLoadAllListVm> Handle(GetprocInventoryPostingGroupByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<InventoryPostingGroup> procInventoryPostingGroups = await _procedureAdabter
               .Execute<InventoryPostingGroup>("[Inventory].[proc_Inventory_Posting_GroupLoadByPrimaryKey]", request);
            GetprocInventoryPostingGroupLoadAllListVm vm = new GetprocInventoryPostingGroupLoadAllListVm
            {
                procInventoryPostingGroups = _mapper.Map<IList<InventoryPostingGroup>, IList<GetprocInventoryPostingGroupLoadAllVm>>(procInventoryPostingGroups)
            };

            return vm;
        }
    }
}
