using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupByPrimaryKey
{
    public class GetprocTAXProdPostingGroupQueryHandler : IRequestHandler<GetprocTAXProdPostingGroupByPrimaryKey, GetprocTAXProdPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTAXProdPostingGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTAXProdPostingGroupLoadAllListVm> Handle(GetprocTAXProdPostingGroupByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<TAX_Prod_Posting_Group> procTAXProdPostingGroups = await _procedureAdabter
               .Execute<TAX_Prod_Posting_Group>("[Inventory].[proc_TAX_Prod_Posting_GroupLoadByPrimaryKey]", request);
            GetprocTAXProdPostingGroupLoadAllListVm vm = new GetprocTAXProdPostingGroupLoadAllListVm
            {
                procTAXProdPostingGroups = _mapper.Map<IList<TAX_Prod_Posting_Group>, IList<GetprocTAXProdPostingGroupLoadAllVm>>(procTAXProdPostingGroups)
            };

            return vm;
        }
    }
}
