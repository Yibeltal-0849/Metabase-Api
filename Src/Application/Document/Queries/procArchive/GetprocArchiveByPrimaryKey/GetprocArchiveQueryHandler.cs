using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Document.Quiries.procArchive.GetprocArchiveLoadAll;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procArchive.GetprocArchiveByPrimaryKey
{
    public class GetprocArchiveQueryHandler : IRequestHandler<GetprocArchiveByPrimaryKey, GetprocArchiveLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocArchiveQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocArchiveLoadAllListVm> Handle(GetprocArchiveByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Archive> procArchives = await _procedureAdabter
               .Execute<Archive>("[Document ].[proc_ArchiveLoadByPrimaryKey]", request);
            GetprocArchiveLoadAllListVm vm = new GetprocArchiveLoadAllListVm
            {
                procArchives = _mapper.Map<IList<Archive>, IList<GetprocArchiveLoadAllVm>>(procArchives)
            };

            return vm;
        }
    }
}
