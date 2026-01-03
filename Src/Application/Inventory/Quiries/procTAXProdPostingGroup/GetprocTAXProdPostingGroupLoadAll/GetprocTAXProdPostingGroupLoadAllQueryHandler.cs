using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupLoadAll
{
    class GetprocTAXProdPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocTAXProdPostingGroupLoadAllQuery, GetprocTAXProdPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTAXProdPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTAXProdPostingGroupLoadAllListVm> Handle(GetprocTAXProdPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TAX_Prod_Posting_Group> procTAXProdPostingGroups = await _procedureAdabter
               .Execute<TAX_Prod_Posting_Group>("[Inventory].[proc_TAX_Prod_Posting_GroupLoadAll]");
            GetprocTAXProdPostingGroupLoadAllListVm vm = new GetprocTAXProdPostingGroupLoadAllListVm
            {
                procTAXProdPostingGroups = _mapper.Map<IList<TAX_Prod_Posting_Group>, IList<GetprocTAXProdPostingGroupLoadAllVm>>(procTAXProdPostingGroups)
            };

            return vm;
        }
    }
}
