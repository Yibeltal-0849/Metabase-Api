

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;



namespace Application.dbo.Commands.procProperty_Document.procProperty_DocumentUpdate.procProperty_DocumentUpdateCommand
{

    /// @author  Shimels Alem  proc_Property_RegistrationUpdate stored procedure.


    public class procProperty_DocumentUpdateHandler : IRequestHandler<procProperty_DocumentUpdateCommand, IList<Property_DocumentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProperty_DocumentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Property_DocumentID>> Handle( procProperty_DocumentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Property_DocumentID> result = await _procedureAdabter
                .Execute<Property_DocumentID>("[dbo].proc_Property_DocumentUpdate", request);
           
            return result;
        }
    }
}
 