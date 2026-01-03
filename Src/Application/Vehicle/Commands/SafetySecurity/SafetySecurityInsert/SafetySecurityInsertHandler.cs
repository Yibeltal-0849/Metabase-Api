using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.SafetySecurity.SafetySecurityInsert.SafetySecurityInsertCommand
{ 
	 
      public class SafetySecurityInsertHandler : IRequestHandler<SafetySecurityInsertCommand, IList<SafetySecurity_Safety_SecurityID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SafetySecurityInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SafetySecurity_Safety_SecurityID>> Handle( SafetySecurityInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SafetySecurity_Safety_SecurityID> result = await _procedureAdabter
                .Execute<SafetySecurity_Safety_SecurityID>("[Vehicle].Safety_SecurityInsert", request);
           

            return result;
        }
    }
}
 
