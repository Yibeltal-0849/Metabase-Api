



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceProductions.proctblResourceProductionsInsert.proctblResourceProductionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceProductionsInsert stored procedure.


    public class proctblResourceProductionsInsertHandler : IRequestHandler<proctblResourceProductionsInsertCommand, IList<tblResourceProductions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceProductionsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceProductions_id>> Handle( proctblResourceProductionsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceProductions_id> result = await _procedureAdabter
                .Execute<tblResourceProductions_id>("[ProprtyData].proc_tblResourceProductionsInsert", request);
           

            return result;
        }
    }
}
 