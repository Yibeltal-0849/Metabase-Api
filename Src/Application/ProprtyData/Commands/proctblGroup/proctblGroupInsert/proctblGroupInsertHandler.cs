



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblGroup.proctblGroupInsert.proctblGroupInsertCommand
{

    /// @author  Shimels Alem  proc_tblGroupInsert stored procedure.


    public class proctblGroupInsertHandler : IRequestHandler<proctblGroupInsertCommand, IList<tblGroup_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblGroup_id>> Handle( proctblGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblGroup_id> result = await _procedureAdabter
                .Execute<tblGroup_id>("[ProprtyData].proc_tblGroupInsert", request);
           

            return result;
        }
    }
}
 