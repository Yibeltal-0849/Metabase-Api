

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;



namespace Application.dbo.Commands.procPropertyRegistration.procPropertyRegistrationUpdate.procPropertyRegistrationUpdateCommand
{

    /// @author  Shimels Alem  proc_Property_RegistrationUpdate stored procedure.


    public class procPropertyRegistrationUpdateHandler : IRequestHandler<procPropertyRegistrationUpdateCommand, IList<PropertyRegistration_PropertyID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPropertyRegistrationUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PropertyRegistration_PropertyID>> Handle( procPropertyRegistrationUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PropertyRegistration_PropertyID> result = await _procedureAdabter
                .Execute<PropertyRegistration_PropertyID>("[dbo].proc_Property_RegistrationUpdate", request);
           
            return result;
        }
    }
}
 