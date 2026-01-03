using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccJournalEntriesType.GetproccJournalEntriesTypeLoadAll
{
    class GetproccJournalEntriesTypeLoadAllQueryHandler : IRequestHandler<GetproccJournalEntriesTypeLoadAllQuery, GetproccJournalEntriesTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccJournalEntriesTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccJournalEntriesTypeLoadAllListVm> Handle(GetproccJournalEntriesTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CJournalEntriesType> proccJournalEntriesTypes = await _procedureAdabter
               .Execute<CJournalEntriesType>("[FINA].[proc_c_Journal_Entries_TypeLoadAll]");
            GetproccJournalEntriesTypeLoadAllListVm vm = new GetproccJournalEntriesTypeLoadAllListVm
            {
                proccJournalEntriesTypes = _mapper.Map<IList<CJournalEntriesType>, IList<GetproccJournalEntriesTypeLoadAllVm>>(proccJournalEntriesTypes)
            };

            return vm;
        }
    }
}
