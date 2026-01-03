

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblGroup.proctblGroupUpdate.proctblGroupUpdateCommand
{

    /// @author  Shimels Alem  proc_tblGroupUpdate stored procedure.


    public class proctblGroupUpdateHandler : IRequestHandler<proctblGroupUpdateCommand, IList<tblGroup_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblGroup_id>> Handle( proctblGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblGroup_id> result = await _procedureAdabter
                .Execute<tblGroup_id>("[ProprtyData].proc_tblGroupUpdate", request);
           

            return result;
        }
    }
}
 