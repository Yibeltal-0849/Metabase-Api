using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJ_Fixed_Asset_Journal.GetprocJ_Fixed_Asset_JournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJ_Fixed_Asset_Journal.GetprocJ_Fixed_Asset_JournalByPrimaryKey
{
    public class GetprocJ_Fixed_Asset_JournalQueryHandler : IRequestHandler<GetprocJ_Fixed_Asset_JournalByPrimaryKey, GetprocJ_Fixed_Asset_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJ_Fixed_Asset_JournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJ_Fixed_Asset_JournalLoadAllListVm> Handle(GetprocJ_Fixed_Asset_JournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JFixedAssetJournal> procJ_Fixed_Asset_Journals = await _procedureAdabter
               .Execute<JFixedAssetJournal>("[FINA].[J_Fixed_Asset_JournalLoadByPrimaryKey]", request);
            GetprocJ_Fixed_Asset_JournalLoadAllListVm vm = new GetprocJ_Fixed_Asset_JournalLoadAllListVm
            {
                procJ_Fixed_Asset_Journals = _mapper.Map<IList<JFixedAssetJournal>, IList<GetprocJ_Fixed_Asset_JournalLoadAllVm>>(procJ_Fixed_Asset_Journals)
            };

            return vm;
        }
    }
}
