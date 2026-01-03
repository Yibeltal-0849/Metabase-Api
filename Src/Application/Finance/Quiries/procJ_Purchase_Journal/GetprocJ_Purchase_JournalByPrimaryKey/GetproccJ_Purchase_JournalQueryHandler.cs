using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccJ_Purchase_Journal.GetproccJ_Purchase_JournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccJ_Purchase_Journal.GetproccJ_Purchase_JournalByPrimaryKey
{
    public class GetproccJ_Purchase_JournalQueryHandler : IRequestHandler<GetproccJ_Purchase_JournalByPrimaryKey, GetproccJ_Purchase_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccJ_Purchase_JournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccJ_Purchase_JournalLoadAllListVm> Handle(GetproccJ_Purchase_JournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JPurchaseJournal> proccJ_Purchase_Journals = await _procedureAdabter
               .Execute<JPurchaseJournal>("[FINA].[JPurchaseJournalLoadByPrimaryKey]", request);
            GetproccJ_Purchase_JournalLoadAllListVm vm = new GetproccJ_Purchase_JournalLoadAllListVm
            {
                proccJ_Purchase_Journals = _mapper.Map<IList<JPurchaseJournal>, IList<GetproccJ_Purchase_JournalLoadAllVm>>(proccJ_Purchase_Journals)
            };

            return vm;
        }
    }
}
