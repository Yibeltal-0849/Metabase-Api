using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceProduction.proctblResourceProductionDelete.proctblResourceProductionDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResourceProductionDelete stored procedure.


    public class proctblResourceProductionDeleteHandler : IRequestHandler<proctblResourceProductionDeleteCommand, IList<tblResourceProduction_Facility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceProductionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceProduction_Facility_id>> Handle( proctblResourceProductionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceProduction_Facility_id> result = await _procedureAdabter
                .Execute<tblResourceProduction_Facility_id>("[ProprtyData].proc_tblResourceProductionDelete", request);
           

            return result;
        }
    }
}
  