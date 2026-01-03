using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupLoadAll
{
    class GetprocTAXBusPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocTAXBusPostingGroupLoadAllQuery, GetprocTAXBusPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTAXBusPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTAXBusPostingGroupLoadAllListVm> Handle(GetprocTAXBusPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TaxBusPostingGroup> procTAXBusPostingGroups = await _procedureAdabter
               .Execute<TaxBusPostingGroup>("[FINA].[proc_TAX_Bus_Posting_GroupLoadAll]");
            GetprocTAXBusPostingGroupLoadAllListVm vm = new GetprocTAXBusPostingGroupLoadAllListVm
            {
                procTAXBusPostingGroups = _mapper.Map<IList<TaxBusPostingGroup>, IList<GetprocTAXBusPostingGroupLoadAllVm>>(procTAXBusPostingGroups)
            };

            return vm;
        }
    }
}
