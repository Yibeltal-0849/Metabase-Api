using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJPurchaseJournal.GetprocJPurchaseJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJPurchaseJournal.GetprocJPurchaseJournalByPrimaryKey
{
    public class GetprocJPurchaseJournalQueryHandler : IRequestHandler<GetprocJPurchaseJournalByPrimaryKey, GetprocJPurchaseJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJPurchaseJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJPurchaseJournalLoadAllListVm> Handle(GetprocJPurchaseJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JPurchaseJournal> procJPurchaseJournals = await _procedureAdabter
               .Execute<JPurchaseJournal>("[FINA].[proc_J_Purchase_JournalLoadByPrimaryKey]", request);
            GetprocJPurchaseJournalLoadAllListVm vm = new GetprocJPurchaseJournalLoadAllListVm
            {
                procJPurchaseJournals = _mapper.Map<IList<JPurchaseJournal>, IList<GetprocJPurchaseJournalLoadAllVm>>(procJPurchaseJournals)
            };

            return vm;
        }
    }
}
