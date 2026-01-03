using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procArchive.GetprocArchiveLoadAll
{
    class GetprocArchiveLoadAllQueryHandler : IRequestHandler<GetprocArchiveLoadAllQuery, GetprocArchiveLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocArchiveLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocArchiveLoadAllListVm> Handle(GetprocArchiveLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Archive> procArchives = await _procedureAdabter
               .Execute<Archive>("[Document ].[proc_ArchiveLoadAll]");
            GetprocArchiveLoadAllListVm vm = new GetprocArchiveLoadAllListVm
            {
                procArchives = _mapper.Map<IList<Archive>, IList<GetprocArchiveLoadAllVm>>(procArchives)
            };

            return vm;
        }
    }
}
