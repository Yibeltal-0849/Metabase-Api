using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJSalesJournal.GetprocJSalesJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJSalesJournal.GetprocJSalesJournalByPrimaryKey
{
    public class GetprocJSalesJournalQueryHandler : IRequestHandler<GetprocJSalesJournalByPrimaryKey, GetprocJSalesJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJSalesJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJSalesJournalLoadAllListVm> Handle(GetprocJSalesJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JSalesJournal> procJSalesJournals = await _procedureAdabter
               .Execute<JSalesJournal>("[FINA].[proc_J_Sales_JournalLoadByPrimaryKey]", request);
            GetprocJSalesJournalLoadAllListVm vm = new GetprocJSalesJournalLoadAllListVm
            {
                procJSalesJournals = _mapper.Map<IList<JSalesJournal>, IList<GetprocJSalesJournalLoadAllVm>>(procJSalesJournals)
            };

            return vm;
        }
    }
}
