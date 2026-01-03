using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJ_Phys_Inventory_Journal.GetprocJ_Phys_Inventory_JournalLoadAll
{
    class GetprocJ_Phys_Inventory_JournalLoadAllQueryHandler : IRequestHandler<GetprocJ_Phys_Inventory_JournalLoadAllQuery, GetprocJ_Phys_Inventory_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJ_Phys_Inventory_JournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJ_Phys_Inventory_JournalLoadAllListVm> Handle(GetprocJ_Phys_Inventory_JournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<J_Phys_Inventory_Journal> procJ_Phys_Inventory_Journals = await _procedureAdabter
               .Execute<J_Phys_Inventory_Journal>("[FINA].[proc_J_Phys_Inventory_JournalLoadAll]");
            GetprocJ_Phys_Inventory_JournalLoadAllListVm vm = new GetprocJ_Phys_Inventory_JournalLoadAllListVm
            {
                procJ_Phys_Inventory_Journals = _mapper.Map<IList<J_Phys_Inventory_Journal>, IList<GetprocJ_Phys_Inventory_JournalLoadAllVm>>(procJ_Phys_Inventory_Journals)
            };

            return vm;
        }
    }
}
