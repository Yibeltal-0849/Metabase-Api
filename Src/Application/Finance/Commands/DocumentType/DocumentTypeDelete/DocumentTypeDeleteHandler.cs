using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.DocumentType.DocumentTypeDelete.DocumentTypeDeleteCommand
{

    /// @author  Shimels Alem  Document_TypeDelete stored procedure.


    public class DocumentTypeDeleteHandler : IRequestHandler<DocumentTypeDeleteCommand, IList<DocumentType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DocumentTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DocumentType_Name>> Handle( DocumentTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<DocumentType_Name> result = await _procedureAdabter
                .Execute<DocumentType_Name>("[FINA].Document_TypeDelete", request);
           

            return result;
        }
    }
}
  