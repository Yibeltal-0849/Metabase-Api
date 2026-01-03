

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblVarableBasedTables.proctblVarableBasedTablesUpdate.proctblVarableBasedTablesUpdateCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTablesUpdate stored procedure.


    public class proctblVarableBasedTablesUpdateHandler : IRequestHandler<proctblVarableBasedTablesUpdateCommand, IList<tblVarableBasedTables_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableBasedTablesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableBasedTables_id>> Handle( proctblVarableBasedTablesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableBasedTables_id> result = await _procedureAdabter
                .Execute<tblVarableBasedTables_id>("[ProprtyData].proc_tblVarableBasedTablesUpdate", request);
           

            return result;
        }
    }
}
 