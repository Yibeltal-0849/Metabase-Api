using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupByPrimaryKey
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
           
            IList<TaxProdPostingGroup> procTAXProdPostingGroups = await _procedureAdabter
               .Execute<TaxProdPostingGroup>("[FINA].[proc_TAX_Prod_Posting_GroupLoadByPrimaryKey]", request);
            GetprocTAXProdPostingGroupLoadAllListVm vm = new GetprocTAXProdPostingGroupLoadAllListVm
            {
                procTAXProdPostingGroups = _mapper.Map<IList<TaxProdPostingGroup>, IList<GetprocTAXProdPostingGroupLoadAllVm>>(procTAXProdPostingGroups)
            };

            return vm;
        }
    }
}
