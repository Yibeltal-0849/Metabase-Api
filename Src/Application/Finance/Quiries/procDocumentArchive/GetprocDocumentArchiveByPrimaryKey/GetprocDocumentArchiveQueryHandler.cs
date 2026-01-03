using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procDocumentArchive.GetprocDocumentArchiveLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Document;

namespace Application.Finance.Quiries.procDocumentArchive.GetprocDocumentArchiveByPrimaryKey
{
    public class GetprocDocumentArchiveQueryHandler : IRequestHandler<GetprocDocumentArchiveByPrimaryKey, GetprocDocumentArchiveLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocDocumentArchiveQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDocumentArchiveLoadAllListVm> Handle(GetprocDocumentArchiveByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<DocumentArchive> procDocumentArchives = await _procedureAdabter
               .Execute<DocumentArchive>("[FINA].[proc_Document_ArchiveLoadByPrimaryKey]", request);
            GetprocDocumentArchiveLoadAllListVm vm = new GetprocDocumentArchiveLoadAllListVm
            {
                procDocumentArchives = _mapper.Map<IList<DocumentArchive>, IList<GetprocDocumentArchiveLoadAllVm>>(procDocumentArchives)
            };

            return vm;
        }
    }
}
