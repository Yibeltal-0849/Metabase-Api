

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResourceProduction.proctblResourceProductionUpdate.proctblResourceProductionUpdateCommand
{

    /// @author  Shimels Alem  proc_tblResourceProductionUpdate stored procedure.


    public class proctblResourceProductionUpdateHandler : IRequestHandler<proctblResourceProductionUpdateCommand, IList<tblResourceProduction_Facility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceProductionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceProduction_Facility_id>> Handle( proctblResourceProductionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceProduction_Facility_id> result = await _procedureAdabter
                .Execute<tblResourceProduction_Facility_id>("[ProprtyData].proc_tblResourceProductionUpdate", request);
           

            return result;
        }
    }
}
 