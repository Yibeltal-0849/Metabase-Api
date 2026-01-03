



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblConsumed.proctblConsumedInsert.proctblConsumedInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumedInsert stored procedure.


    public class proctblConsumedInsertHandler : IRequestHandler<proctblConsumedInsertCommand, IList<tblConsumed_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumedInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumed_id>> Handle( proctblConsumedInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumed_id> result = await _procedureAdabter
                .Execute<tblConsumed_id>("[ProprtyData].proc_tblConsumedInsert", request);
           

            return result;
        }
    }
}
 