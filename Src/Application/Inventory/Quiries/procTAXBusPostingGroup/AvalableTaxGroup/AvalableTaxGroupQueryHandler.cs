using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procTAXBusPostingGroup.AvalableTaxGroup
{
    public class AvalableTaxGroupQueryHandler : IRequestHandler<AvalableTaxGroup, GetprocTAXBusPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public AvalableTaxGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTAXBusPostingGroupLoadAllListVm> Handle(AvalableTaxGroup request, CancellationToken cancellationToken)
        {
           
            IList<TAX_Bus_Posting_Group> procTAXBusPostingGroups = await _procedureAdabter
               .Execute<TAX_Bus_Posting_Group>("[FINA].[Avalable_TaxGroup]", request);
            GetprocTAXBusPostingGroupLoadAllListVm vm = new GetprocTAXBusPostingGroupLoadAllListVm
            {
                procTAXBusPostingGroups = _mapper.Map<IList<TAX_Bus_Posting_Group>, IList<GetprocTAXBusPostingGroupLoadAllVm>>(procTAXBusPostingGroups)
            };

            return vm;
        }
    }
}
