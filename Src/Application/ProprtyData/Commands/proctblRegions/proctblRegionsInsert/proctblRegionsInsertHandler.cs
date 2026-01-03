



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblRegions.proctblRegionsInsert.proctblRegionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblRegionsInsert stored procedure.


    public class proctblRegionsInsertHandler : IRequestHandler<proctblRegionsInsertCommand, IList<tblRegions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblRegionsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblRegions_id>> Handle( proctblRegionsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblRegions_id> result = await _procedureAdabter
                .Execute<tblRegions_id>("[ProprtyData].proc_tblRegionsInsert", request);
           

            return result;
        }
    }
}
 