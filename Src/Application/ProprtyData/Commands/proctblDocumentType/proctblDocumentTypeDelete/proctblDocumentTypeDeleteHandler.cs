using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDocumentType.proctblDocumentTypeDelete.proctblDocumentTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_tblDocument_TypeDelete stored procedure.


    public class proctblDocumentTypeDeleteHandler : IRequestHandler<proctblDocumentTypeDeleteCommand, IList<tblDocumentType_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDocumentTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDocumentType_id>> Handle( proctblDocumentTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblDocumentType_id> result = await _procedureAdabter
                .Execute<tblDocumentType_id>("[ProprtyData].proc_tblDocument_TypeDelete", request);
           

            return result;
        }
    }
}
  