

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblVarableBasedTableDetail.proctblVarableBasedTableDetailUpdate.proctblVarableBasedTableDetailUpdateCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTable_DetailUpdate stored procedure.


    public class proctblVarableBasedTableDetailUpdateHandler : IRequestHandler<proctblVarableBasedTableDetailUpdateCommand, IList<tblVarableBasedTableDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVarableBasedTableDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVarableBasedTableDetail_id>> Handle( proctblVarableBasedTableDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblVarableBasedTableDetail_id> result = await _procedureAdabter
                .Execute<tblVarableBasedTableDetail_id>("[ProprtyData].proc_tblVarableBasedTable_DetailUpdate", request);
           

            return result;
        }
    }
}
 