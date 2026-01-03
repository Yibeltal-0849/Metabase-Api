using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblVarableTables.GetproctblVarableTablesLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblVarableTables.GetproctblVarableTablesByPrimaryKey
{
    public class GetproctblVarableTablesQueryHandler : IRequestHandler<GetproctblVarableTablesByPrimaryKey, GetproctblVarableTablesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblVarableTablesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblVarableTablesLoadAllListVm> Handle(GetproctblVarableTablesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblVarableTables> proctblVarableTabless = await _procedureAdabter
               .Execute<tblVarableTables>("[ProprtyData].[proc_tblVarable_TablesLoadByPrimaryKey]", request);
            GetproctblVarableTablesLoadAllListVm vm = new GetproctblVarableTablesLoadAllListVm
            {
                proctblVarableTabless = _mapper.Map<IList<tblVarableTables>, IList<GetproctblVarableTablesLoadAllVm>>(proctblVarableTabless)
            };

            return vm;
        }
    }
}
