using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFaclitiyDescription.proctblFaclitiyDescriptionDelete.proctblFaclitiyDescriptionDeleteCommand
{

    /// @author  Shimels Alem  proc_tblFaclitiy_DescriptionDelete stored procedure.


    public class proctblFaclitiyDescriptionDeleteHandler : IRequestHandler<proctblFaclitiyDescriptionDeleteCommand, IList<tblFaclitiyDescription_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFaclitiyDescriptionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFaclitiyDescription_id>> Handle( proctblFaclitiyDescriptionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblFaclitiyDescription_id> result = await _procedureAdabter
                .Execute<tblFaclitiyDescription_id>("[ProprtyData].proc_tblFaclitiy_DescriptionDelete", request);
           

            return result;
        }
    }
}
  