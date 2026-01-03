



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;


namespace Application.Document.Commands.procArchiveType.procArchiveTypeInsert.procArchiveTypeInsertCommand
{

    /// @author  Shimels Alem  proc_Archive_TypeInsert stored procedure.


    public class procArchiveTypeInsertHandler : IRequestHandler<procArchiveTypeInsertCommand, IList<Archive_Type_Name_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procArchiveTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Archive_Type_Name_Type>> Handle( procArchiveTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Archive_Type_Name_Type> result = await _procedureAdabter
                .Execute<Archive_Type_Name_Type>("[Document].proc_Archive_TypeInsert", request);
           

            return result;
        }
    }
}
 