using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDocumentDetail.proctblDocumentDetailDelete.proctblDocumentDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_tblDocument_DetailDelete stored procedure.


    public class proctblDocumentDetailDeleteHandler : IRequestHandler<proctblDocumentDetailDeleteCommand, IList<tblDocumentDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDocumentDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDocumentDetail_id>> Handle( proctblDocumentDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblDocumentDetail_id> result = await _procedureAdabter
                .Execute<tblDocumentDetail_id>("[ProprtyData].proc_tblDocument_DetailDelete", request);
           

            return result;
        }
    }
}
  