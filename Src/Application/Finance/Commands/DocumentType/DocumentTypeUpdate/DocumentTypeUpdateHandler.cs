

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.DocumentType.DocumentTypeUpdate.DocumentTypeUpdateCommand
{

    /// @author  Shimels Alem  Document_TypeUpdate stored procedure.


    public class DocumentTypeUpdateHandler : IRequestHandler<DocumentTypeUpdateCommand, IList<DocumentType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DocumentTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DocumentType_Name>> Handle( DocumentTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<DocumentType_Name> result = await _procedureAdabter
                .Execute<DocumentType_Name>("[FINA].Document_TypeUpdate", request);
           

            return result;
        }
    }
}
 