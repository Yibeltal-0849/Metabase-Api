using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblRegions.proctblRegionsDelete.proctblRegionsDeleteCommand
{

    /// @author  Shimels Alem  proc_tblRegionsDelete stored procedure.


    public class proctblRegionsDeleteHandler : IRequestHandler<proctblRegionsDeleteCommand, IList<tblRegions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblRegionsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblRegions_id>> Handle( proctblRegionsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblRegions_id> result = await _procedureAdabter
                .Execute<tblRegions_id>("[ProprtyData].proc_tblRegionsDelete", request);
           

            return result;
        }
    }
}
  