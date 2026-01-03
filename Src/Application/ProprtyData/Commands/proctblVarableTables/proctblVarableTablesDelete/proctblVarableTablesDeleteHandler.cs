using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblVarableTables.proctblVarableTablesDelete.proctblVarableTablesDeleteCommand
{

    /// @author  Shimels Alem  proc_tblVarable_TablesDelete stored procedure.


    public class proctblVarableTablesDeleteHandler : IRequestHandler<proctblVarableTablesDeleteCommand, IList<tblVarableTables_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableTablesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableTables_id>> Handle( proctblVarableTablesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableTables_id> result = await _procedureAdabter
                .Execute<tblVarableTables_id>("[ProprtyData].proc_tblVarable_TablesDelete", request);
           

            return result;
        }
    }
}
  