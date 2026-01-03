using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procDocumentArchive.GetprocDocumentArchiveLoadAll
{
    class GetprocDocumentArchiveLoadAllQueryHandler : IRequestHandler<GetprocDocumentArchiveLoadAllQuery, GetprocDocumentArchiveLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDocumentArchiveLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDocumentArchiveLoadAllListVm> Handle(GetprocDocumentArchiveLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<DocumentArchive> procDocumentArchives = await _procedureAdabter
               .Execute<DocumentArchive>("[FINA].[proc_Document_ArchiveLoadAll]");
            GetprocDocumentArchiveLoadAllListVm vm = new GetprocDocumentArchiveLoadAllListVm
            {
                procDocumentArchives = _mapper.Map<IList<DocumentArchive>, IList<GetprocDocumentArchiveLoadAllVm>>(procDocumentArchives)
            };

            return vm;
        }
    }
}
