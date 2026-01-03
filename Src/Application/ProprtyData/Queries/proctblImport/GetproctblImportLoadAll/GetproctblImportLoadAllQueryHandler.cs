using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblImport.GetproctblImportLoadAll
{
    class GetproctblImportLoadAllQueryHandler : IRequestHandler<GetproctblImportLoadAllQuery, GetproctblImportLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblImportLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblImportLoadAllListVm> Handle(GetproctblImportLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblImport> proctblImports = await _procedureAdabter
               .Execute<tblImport>("[ProprtyData].[proc_tblImportLoadAll]");
            GetproctblImportLoadAllListVm vm = new GetproctblImportLoadAllListVm
            {
                proctblImports = _mapper.Map<IList<tblImport>, IList<GetproctblImportLoadAllVm>>(proctblImports)
            };

            return vm;
        }
    }
}
