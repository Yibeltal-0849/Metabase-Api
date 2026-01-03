

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResourceProductions.proctblResourceProductionsUpdate.proctblResourceProductionsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblResourceProductionsUpdate stored procedure.


    public class proctblResourceProductionsUpdateHandler : IRequestHandler<proctblResourceProductionsUpdateCommand, IList<tblResourceProductions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceProductionsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceProductions_id>> Handle( proctblResourceProductionsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceProductions_id> result = await _procedureAdabter
                .Execute<tblResourceProductions_id>("[ProprtyData].proc_tblResourceProductionsUpdate", request);
           

            return result;
        }
    }
}
 