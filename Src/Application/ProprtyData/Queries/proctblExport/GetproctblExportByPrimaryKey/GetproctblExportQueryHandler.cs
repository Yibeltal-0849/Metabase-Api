using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblExport.GetproctblExportLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblExport.GetproctblExportByPrimaryKey
{
    public class GetproctblExportQueryHandler : IRequestHandler<GetproctblExportByPrimaryKey, GetproctblExportLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblExportQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblExportLoadAllListVm> Handle(GetproctblExportByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblExport> proctblExports = await _procedureAdabter
               .Execute<tblExport>("[ProprtyData].[proc_tblExportLoadByPrimaryKey]", request);
            GetproctblExportLoadAllListVm vm = new GetproctblExportLoadAllListVm
            {
                proctblExports = _mapper.Map<IList<tblExport>, IList<GetproctblExportLoadAllVm>>(proctblExports)
            };

            return vm;
        }
    }
}
