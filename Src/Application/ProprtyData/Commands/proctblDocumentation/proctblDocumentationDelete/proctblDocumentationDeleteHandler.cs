using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDocumentation.proctblDocumentationDelete.proctblDocumentationDeleteCommand
{

    /// @author  Shimels Alem  proc_tblDocumentationDelete stored procedure.


    public class proctblDocumentationDeleteHandler : IRequestHandler<proctblDocumentationDeleteCommand, IList<tblDocumentation_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDocumentationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDocumentation_id>> Handle( proctblDocumentationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblDocumentation_id> result = await _procedureAdabter
                .Execute<tblDocumentation_id>("[ProprtyData].proc_tblDocumentationDelete", request);
           

            return result;
        }
    }
}
  