



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;


namespace Application.dbo.Commands.procPropertyRegistration.procPropertyRegistrationInsert.procPropertyRegistrationInsertCommand
{

    /// @author  Shimels Alem  proc_Property_RegistrationInsert stored procedure.


    public class procPropertyRegistrationInsertHandler : IRequestHandler<procPropertyRegistrationInsertCommand, IList<PropertyRegistration_PropertyID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPropertyRegistrationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PropertyRegistration_PropertyID>> Handle( procPropertyRegistrationInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PropertyRegistration_PropertyID> result = await _procedureAdabter
                .Execute<PropertyRegistration_PropertyID>("[dbo].proc_Property_RegistrationInsert", request);
           

            return result;
        }
    }
}
 