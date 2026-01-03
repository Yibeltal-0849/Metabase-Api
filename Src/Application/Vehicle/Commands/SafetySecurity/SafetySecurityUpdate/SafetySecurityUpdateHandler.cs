using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.SafetySecurity.SafetySecurityUpdate.SafetySecurityUpdateCommand
{ 

      public class SafetySecurityUpdateHandler : IRequestHandler<SafetySecurityUpdateCommand, IList<SafetySecurity_Safety_SecurityID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SafetySecurityUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SafetySecurity_Safety_SecurityID>> Handle( SafetySecurityUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SafetySecurity_Safety_SecurityID> result = await _procedureAdabter
                .Execute<SafetySecurity_Safety_SecurityID>("[Vehicle].Safety_SecurityUpdate", request);
           

            return result;
        }
    }
}
 
