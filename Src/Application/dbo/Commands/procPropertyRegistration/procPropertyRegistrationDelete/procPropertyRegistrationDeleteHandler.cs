using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procPropertyRegistration.procPropertyRegistrationDelete.procPropertyRegistrationDeleteCommand
{

    /// @author  Shimels Alem  proc_Property_RegistrationDelete stored procedure.


    public class procPropertyRegistrationDeleteHandler : IRequestHandler<procPropertyRegistrationDeleteCommand, IList<PropertyRegistration_PropertyID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPropertyRegistrationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PropertyRegistration_PropertyID>> Handle( procPropertyRegistrationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PropertyRegistration_PropertyID> result = await _procedureAdabter
                .Execute<PropertyRegistration_PropertyID>("[dbo].proc_Property_RegistrationDelete", request);
           

            return result;
        }
    }
}
  