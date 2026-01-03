



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceFacility.proctblResourceFacilityInsert.proctblResourceFacilityInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_FacilityInsert stored procedure.


    public class proctblResourceFacilityInsertHandler : IRequestHandler<proctblResourceFacilityInsertCommand, IList<tblResourceFacility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceFacilityInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceFacility_id>> Handle( proctblResourceFacilityInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceFacility_id> result = await _procedureAdabter
                .Execute<tblResourceFacility_id>("[ProprtyData].proc_tblResource_FacilityInsert", request);
           

            return result;
        }
    }
}
 