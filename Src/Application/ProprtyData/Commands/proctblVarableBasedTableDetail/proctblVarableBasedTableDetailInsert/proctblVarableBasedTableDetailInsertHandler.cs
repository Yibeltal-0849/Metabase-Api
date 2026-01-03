



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblVarableBasedTableDetail.proctblVarableBasedTableDetailInsert.proctblVarableBasedTableDetailInsertCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTable_DetailInsert stored procedure.


    public class proctblVarableBasedTableDetailInsertHandler : IRequestHandler<proctblVarableBasedTableDetailInsertCommand, IList<tblVarableBasedTableDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableBasedTableDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableBasedTableDetail_id>> Handle( proctblVarableBasedTableDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableBasedTableDetail_id> result = await _procedureAdabter
                .Execute<tblVarableBasedTableDetail_id>("[ProprtyData].proc_tblVarableBasedTable_DetailInsert", request);
           

            return result;
        }
    }
}
 