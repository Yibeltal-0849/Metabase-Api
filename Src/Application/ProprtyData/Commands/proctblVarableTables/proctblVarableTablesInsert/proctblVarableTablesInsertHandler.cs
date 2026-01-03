



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblVarableTables.proctblVarableTablesInsert.proctblVarableTablesInsertCommand
{

    /// @author  Shimels Alem  proc_tblVarable_TablesInsert stored procedure.


    public class proctblVarableTablesInsertHandler : IRequestHandler<proctblVarableTablesInsertCommand, IList<tblVarableTables_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableTablesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableTables_id>> Handle( proctblVarableTablesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableTables_id> result = await _procedureAdabter
                .Execute<tblVarableTables_id>("[ProprtyData].proc_tblVarable_TablesInsert", request);
           

            return result;
        }
    }
}
 