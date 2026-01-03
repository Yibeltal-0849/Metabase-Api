using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Document.Commands.procArchiveType.procArchiveTypeDelete.procArchiveTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_Archive_TypeDelete stored procedure.


    public class procArchiveTypeDeleteHandler : IRequestHandler<procArchiveTypeDeleteCommand, IList<Archive_Type_Name_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procArchiveTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Archive_Type_Name_Type>> Handle( procArchiveTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Archive_Type_Name_Type> result = await _procedureAdabter
                .Execute<Archive_Type_Name_Type>("[Document].proc_Archive_TypeDelete", request);
           

            return result;
        }
    }
}
  