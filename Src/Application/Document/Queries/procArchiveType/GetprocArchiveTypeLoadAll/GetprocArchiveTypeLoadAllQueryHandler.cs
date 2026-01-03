using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procArchiveType.GetprocArchiveTypeLoadAll
{
    class GetprocArchiveTypeLoadAllQueryHandler : IRequestHandler<GetprocArchiveTypeLoadAllQuery, GetprocArchiveTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocArchiveTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocArchiveTypeLoadAllListVm> Handle(GetprocArchiveTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Archive_Type> procArchiveTypes = await _procedureAdabter
               .Execute<Archive_Type>("[Document].[proc_Archive_TypeLoadAll]");
            GetprocArchiveTypeLoadAllListVm vm = new GetprocArchiveTypeLoadAllListVm
            {
                procArchiveTypes = _mapper.Map<IList<Archive_Type>, IList<GetprocArchiveTypeLoadAllVm>>(procArchiveTypes)
            };

            return vm;
        }
    }
}
