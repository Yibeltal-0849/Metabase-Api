using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFacilityType.proctblFacilityTypeDelete.proctblFacilityTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_tblFacility_TypeDelete stored procedure.


    public class proctblFacilityTypeDeleteHandler : IRequestHandler<proctblFacilityTypeDeleteCommand, IList<tblFacility_Type_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacility_Type_id>> Handle( proctblFacilityTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblFacility_Type_id> result = await _procedureAdabter
                .Execute<tblFacility_Type_id>("[ProprtyData].proc_tblFacility_TypeDelete", request);
           

            return result;
        }
    }
}
  