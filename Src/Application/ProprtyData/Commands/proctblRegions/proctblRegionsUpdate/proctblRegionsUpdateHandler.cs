

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblRegions.proctblRegionsUpdate.proctblRegionsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblRegionsUpdate stored procedure.


    public class proctblRegionsUpdateHandler : IRequestHandler<proctblRegionsUpdateCommand, IList<tblRegions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblRegionsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblRegions_id>> Handle( proctblRegionsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblRegions_id> result = await _procedureAdabter
                .Execute<tblRegions_id>("[ProprtyData].proc_tblRegionsUpdate", request);
           

            return result;
        }
    }
}
 