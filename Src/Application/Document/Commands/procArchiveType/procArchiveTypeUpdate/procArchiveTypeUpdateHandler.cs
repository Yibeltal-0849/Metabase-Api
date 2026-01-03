

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Document.Commands.procArchiveType.procArchiveTypeUpdate.procArchiveTypeUpdateCommand
{

    /// @author  Shimels Alem  proc_Archive_TypeUpdate stored procedure.


    public class procArchiveTypeUpdateHandler : IRequestHandler<procArchiveTypeUpdateCommand, IList<Archive_Type_Name_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procArchiveTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Archive_Type_Name_Type>> Handle( procArchiveTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Archive_Type_Name_Type> result = await _procedureAdabter
                .Execute<Archive_Type_Name_Type>("[Document].proc_Archive_TypeUpdate", request);
           

            return result;
        }
    }
}
 