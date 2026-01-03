



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblWindPotential.proctblWindPotentialInsert.proctblWindPotentialInsertCommand
{

    /// @author  Shimels Alem  proc_tblWindPotentialInsert stored procedure.


    public class proctblWindPotentialInsertHandler : IRequestHandler<proctblWindPotentialInsertCommand, IList<tblWindPotential_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblWindPotentialInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblWindPotential_id>> Handle( proctblWindPotentialInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblWindPotential_id> result = await _procedureAdabter
                .Execute<tblWindPotential_id>("[ProprtyData].proc_tblWindPotentialInsert", request);
           

            return result;
        }
    }
}
 