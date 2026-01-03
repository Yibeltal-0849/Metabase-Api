



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;


namespace Application.dbo.Commands.procProperty_Document.procProperty_DocumentInsert.procProperty_DocumentInsertCommand
{

    /// @author  Shimels Alem  proc_Property_RegistrationInsert stored procedure.


    public class procProperty_DocumentInsertHandler : IRequestHandler<procProperty_DocumentInsertCommand, IList<Property_DocumentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProperty_DocumentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Property_DocumentID>> Handle( procProperty_DocumentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Property_DocumentID> result = await _procedureAdabter
                .Execute<Property_DocumentID>("[dbo].proc_Property_DocumentInsert", request);
           

            return result;
        }
    }
}
 