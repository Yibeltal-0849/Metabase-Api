using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procProperty_Document.procProperty_DocumentDelete.procProperty_DocumentDeleteCommand
{

    /// @author  Shimels Alem  proc_Property_RegistrationDelete stored procedure.


    public class procProperty_DocumentDeleteHandler : IRequestHandler<procProperty_DocumentDeleteCommand, IList<Property_DocumentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProperty_DocumentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Property_DocumentID>> Handle( procProperty_DocumentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Property_DocumentID> result = await _procedureAdabter
                .Execute<Property_DocumentID>("[dbo].proc_Property_DocumentDelete", request);
           

            return result;
        }
    }
}
  