using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblVarableBasedTables.GetproctblVarableBasedTablesLoadAll
{
    class GetproctblVarableBasedTablesLoadAllQueryHandler : IRequestHandler<GetproctblVarableBasedTablesLoadAllQuery, GetproctblVarableBasedTablesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblVarableBasedTablesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblVarableBasedTablesLoadAllListVm> Handle(GetproctblVarableBasedTablesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblVarableBasedTables> proctblVarableBasedTabless = await _procedureAdabter
               .Execute<tblVarableBasedTables>("[ProprtyData].[proc_tblVarableBasedTablesLoadAll]");
            GetproctblVarableBasedTablesLoadAllListVm vm = new GetproctblVarableBasedTablesLoadAllListVm
            {
                proctblVarableBasedTabless = _mapper.Map<IList<tblVarableBasedTables>, IList<GetproctblVarableBasedTablesLoadAllVm>>(proctblVarableBasedTabless)
            };

            return vm;
        }
    }
}
