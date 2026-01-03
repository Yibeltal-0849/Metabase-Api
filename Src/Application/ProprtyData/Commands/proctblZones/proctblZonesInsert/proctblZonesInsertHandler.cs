



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblZones.proctblZonesInsert.proctblZonesInsertCommand
{

    /// @author  Shimels Alem  proc_tblZonesInsert stored procedure.


    public class proctblZonesInsertHandler : IRequestHandler<proctblZonesInsertCommand, IList<tblZones_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblZonesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblZones_id>> Handle( proctblZonesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblZones_id> result = await _procedureAdabter
                .Execute<tblZones_id>("[ProprtyData].proc_tblZonesInsert", request);
           

            return result;
        }
    }
}
 