



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceAmount.proctblResourceAmountInsert.proctblResourceAmountInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceAmountInsert stored procedure.


    public class proctblResourceAmountInsertHandler : IRequestHandler<proctblResourceAmountInsertCommand, IList<tblResourceAmount_Resource_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceAmountInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceAmount_Resource_id>> Handle( proctblResourceAmountInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceAmount_Resource_id> result = await _procedureAdabter
                .Execute<tblResourceAmount_Resource_id>("[ProprtyData].proc_tblResourceAmountInsert", request);
           

            return result;
        }
    }
}
 