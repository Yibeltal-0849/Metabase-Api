

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblGroupcons.proctblGroupconsUpdate.proctblGroupconsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblGroup_consUpdate stored procedure.


    public class proctblGroupconsUpdateHandler : IRequestHandler<proctblGroupconsUpdateCommand, IList<tblGroupcons_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblGroupconsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblGroupcons_id>> Handle( proctblGroupconsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblGroupcons_id> result = await _procedureAdabter
                .Execute<tblGroupcons_id>("[ProprtyData].proc_tblGroup_consUpdate", request);
           

            return result;
        }
    }
}
 