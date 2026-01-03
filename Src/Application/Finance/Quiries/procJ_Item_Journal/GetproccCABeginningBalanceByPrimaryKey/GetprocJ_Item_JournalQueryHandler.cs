using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJ_Item_Journal.GetprocJ_Item_JournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJ_Item_Journal.GetprocJ_Item_JournalByPrimaryKey
{
    public class GetprocJ_Item_JournalQueryHandler : IRequestHandler<GetprocJ_Item_JournalByPrimaryKey, GetprocJ_Item_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJ_Item_JournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJ_Item_JournalLoadAllListVm> Handle(GetprocJ_Item_JournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JItemJournal> procJ_Item_Journals = await _procedureAdabter
               .Execute<JItemJournal>("[FINA].[J_Item_JournalLoadByPrimaryKey]", request);
            GetprocJ_Item_JournalLoadAllListVm vm = new GetprocJ_Item_JournalLoadAllListVm
            {
                procJ_Item_Journals = _mapper.Map<IList<JItemJournal>, IList<GetprocJ_Item_JournalLoadAllVm>>(procJ_Item_Journals)
            };

            return vm;
        }
    }
}
