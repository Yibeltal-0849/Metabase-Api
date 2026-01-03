using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJ_Item_Journal.GetprocJ_Item_JournalLoadAll
{
    class GetprocJ_Item_JournalLoadAllQueryHandler : IRequestHandler<GetprocJ_Item_JournalLoadAllQuery, GetprocJ_Item_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJ_Item_JournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJ_Item_JournalLoadAllListVm> Handle(GetprocJ_Item_JournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JItemJournal> procJ_Item_Journals = await _procedureAdabter
               .Execute<JItemJournal>("[FINA].[J_Item_JournalLoadAll]");
            GetprocJ_Item_JournalLoadAllListVm vm = new GetprocJ_Item_JournalLoadAllListVm
            {
                procJ_Item_Journals = _mapper.Map<IList<JItemJournal>, IList<GetprocJ_Item_JournalLoadAllVm>>(procJ_Item_Journals)
            };

            return vm;
        }
    }
}
