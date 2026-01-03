



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.DocumentType.DocumentTypeInsert.DocumentTypeInsertCommand
{

    /// @author  Shimels Alem  Document_TypeInsert stored procedure.


    public class DocumentTypeInsertHandler : IRequestHandler<DocumentTypeInsertCommand, IList<DocumentType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DocumentTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DocumentType_Name>> Handle( DocumentTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<DocumentType_Name> result = await _procedureAdabter
                .Execute<DocumentType_Name>("[FINA].Document_TypeInsert", request);
           

            return result;
        }
    }
}
 