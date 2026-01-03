

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblConsumed.proctblConsumedUpdate.proctblConsumedUpdateCommand
{

    /// @author  Shimels Alem  proc_tblConsumedUpdate stored procedure.


    public class proctblConsumedUpdateHandler : IRequestHandler<proctblConsumedUpdateCommand, IList<tblConsumed_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumedUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumed_id>> Handle( proctblConsumedUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumed_id> result = await _procedureAdabter
                .Execute<tblConsumed_id>("[ProprtyData].proc_tblConsumedUpdate", request);
           

            return result;
        }
    }
}
 