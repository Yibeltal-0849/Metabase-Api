using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblVarableBasedTableDetail.proctblVarableBasedTableDetailDelete.proctblVarableBasedTableDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTable_DetailDelete stored procedure.


    public class proctblVarableBasedTableDetailDeleteHandler : IRequestHandler<proctblVarableBasedTableDetailDeleteCommand, IList<tblVarableBasedTableDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableBasedTableDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableBasedTableDetail_id>> Handle( proctblVarableBasedTableDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableBasedTableDetail_id> result = await _procedureAdabter
                .Execute<tblVarableBasedTableDetail_id>("[ProprtyData].proc_tblVarableBasedTable_DetailDelete", request);
           

            return result;
        }
    }
}
  