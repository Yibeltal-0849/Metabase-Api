using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.SafetySecurity.SafetySecurityDelete.SafetySecurityDeleteCommand
{ 	 
	 
      public class SafetySecurityDeleteHandler : IRequestHandler<SafetySecurityDeleteCommand, IList<SafetySecurity_Safety_SecurityID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SafetySecurityDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SafetySecurity_Safety_SecurityID>> Handle( SafetySecurityDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SafetySecurity_Safety_SecurityID> result = await _procedureAdabter
                .Execute<SafetySecurity_Safety_SecurityID>("[Vehicle].Safety_SecurityDelete", request);
           

            return result;
        }
    }
}
 
