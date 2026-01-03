



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblVarableBasedTables.proctblVarableBasedTablesInsert.proctblVarableBasedTablesInsertCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTablesInsert stored procedure.


    public class proctblVarableBasedTablesInsertHandler : IRequestHandler<proctblVarableBasedTablesInsertCommand, IList<tblVarableBasedTables_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableBasedTablesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableBasedTables_id>> Handle( proctblVarableBasedTablesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableBasedTables_id> result = await _procedureAdabter
                .Execute<tblVarableBasedTables_id>("[ProprtyData].proc_tblVarableBasedTablesInsert", request);
           

            return result;
        }
    }
}
 