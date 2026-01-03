using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccJournalEntriesType.GetproccJournalEntriesTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccJournalEntriesType.GetproccJournalEntriesTypeByPrimaryKey
{
    public class GetproccJournalEntriesTypeQueryHandler : IRequestHandler<GetproccJournalEntriesTypeByPrimaryKey, GetproccJournalEntriesTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccJournalEntriesTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccJournalEntriesTypeLoadAllListVm> Handle(GetproccJournalEntriesTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CJournalEntriesType> proccJournalEntriesTypes = await _procedureAdabter
               .Execute<CJournalEntriesType>("[FINA].[proc_c_Journal_Entries_TypeLoadByPrimaryKey]", request);
            GetproccJournalEntriesTypeLoadAllListVm vm = new GetproccJournalEntriesTypeLoadAllListVm
            {
                proccJournalEntriesTypes = _mapper.Map<IList<CJournalEntriesType>, IList<GetproccJournalEntriesTypeLoadAllVm>>(proccJournalEntriesTypes)
            };

            return vm;
        }
    }
}
