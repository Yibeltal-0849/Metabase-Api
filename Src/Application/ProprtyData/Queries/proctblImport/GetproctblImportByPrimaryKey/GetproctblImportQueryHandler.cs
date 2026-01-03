using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblImport.GetproctblImportLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblImport.GetproctblImportByPrimaryKey
{
    public class GetproctblImportQueryHandler : IRequestHandler<GetproctblImportByPrimaryKey, GetproctblImportLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblImportQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblImportLoadAllListVm> Handle(GetproctblImportByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblImport> proctblImports = await _procedureAdabter
               .Execute<tblImport>("[ProprtyData].[proc_tblImportLoadByPrimaryKey]", request);
            GetproctblImportLoadAllListVm vm = new GetproctblImportLoadAllListVm
            {
                proctblImports = _mapper.Map<IList<tblImport>, IList<GetproctblImportLoadAllVm>>(proctblImports)
            };

            return vm;
        }
    }
}
