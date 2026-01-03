using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.ArchiveType.ArchiveTypeDelete.ArchiveTypeDeleteCommand
{

    /// @author  Shimels Alem  Archive_TypeDelete stored procedure.


    public class ArchiveTypeDeleteHandler : IRequestHandler<ArchiveTypeDeleteCommand, IList<Archive_Type_Name_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ArchiveTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Archive_Type_Name_Type>> Handle( ArchiveTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Archive_Type_Name_Type> result = await _procedureAdabter
                .Execute<Archive_Type_Name_Type>("[Budget].Archive_TypeDelete", request);
           

            return result;
        }
    }
}
  