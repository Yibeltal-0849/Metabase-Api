using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupLoadAll
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
            IList<TaxProdPostingGroup> procTAXProdPostingGroups = await _procedureAdabter
               .Execute<TaxProdPostingGroup>("[FINA].[proc_TAX_Prod_Posting_GroupLoadAll]");
            GetprocTAXProdPostingGroupLoadAllListVm vm = new GetprocTAXProdPostingGroupLoadAllListVm
            {
                procTAXProdPostingGroups = _mapper.Map<IList<TaxProdPostingGroup>, IList<GetprocTAXProdPostingGroupLoadAllVm>>(procTAXProdPostingGroups)
            };

            return vm;
        }
    }
}
