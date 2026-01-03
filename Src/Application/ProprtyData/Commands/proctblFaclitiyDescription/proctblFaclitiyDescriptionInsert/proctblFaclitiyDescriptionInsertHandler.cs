



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblFaclitiyDescription.proctblFaclitiyDescriptionInsert.proctblFaclitiyDescriptionInsertCommand
{

    /// @author  Shimels Alem  proc_tblFaclitiy_DescriptionInsert stored procedure.


    public class proctblFaclitiyDescriptionInsertHandler : IRequestHandler<proctblFaclitiyDescriptionInsertCommand, IList<tblFaclitiyDescription_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFaclitiyDescriptionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFaclitiyDescription_id>> Handle( proctblFaclitiyDescriptionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblFaclitiyDescription_id> result = await _procedureAdabter
                .Execute<tblFaclitiyDescription_id>("[ProprtyData].proc_tblFaclitiy_DescriptionInsert", request);
           

            return result;
        }
    }
}
 