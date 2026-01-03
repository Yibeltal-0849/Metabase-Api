

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblWindPotential.proctblWindPotentialUpdate.proctblWindPotentialUpdateCommand
{

    /// @author  Shimels Alem  proc_tblWindPotentialUpdate stored procedure.


    public class proctblWindPotentialUpdateHandler : IRequestHandler<proctblWindPotentialUpdateCommand, IList<tblWindPotential_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblWindPotentialUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblWindPotential_id>> Handle( proctblWindPotentialUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblWindPotential_id> result = await _procedureAdabter
                .Execute<tblWindPotential_id>("[ProprtyData].proc_tblWindPotentialUpdate", request);
           

            return result;
        }
    }
}
 