using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumed.proctblConsumedDelete.proctblConsumedDeleteCommand
{

    /// @author  Shimels Alem  proc_tblConsumedDelete stored procedure.


    public class proctblConsumedDeleteHandler : IRequestHandler<proctblConsumedDeleteCommand, IList<tblConsumed_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumedDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumed_id>> Handle( proctblConsumedDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumed_id> result = await _procedureAdabter
                .Execute<tblConsumed_id>("[ProprtyData].proc_tblConsumedDelete", request);
           

            return result;
        }
    }
}
  