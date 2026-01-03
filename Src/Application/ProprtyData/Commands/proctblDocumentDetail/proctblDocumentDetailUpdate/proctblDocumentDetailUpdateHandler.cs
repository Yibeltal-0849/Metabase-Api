

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblDocumentDetail.proctblDocumentDetailUpdate.proctblDocumentDetailUpdateCommand
{

    /// @author  Shimels Alem  proc_tblDocument_DetailUpdate stored procedure.


    public class proctblDocumentDetailUpdateHandler : IRequestHandler<proctblDocumentDetailUpdateCommand, IList<tblDocumentDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDocumentDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDocumentDetail_id>> Handle( proctblDocumentDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblDocumentDetail_id> result = await _procedureAdabter
                .Execute<tblDocumentDetail_id>("[ProprtyData].proc_tblDocument_DetailUpdate", request);
           

            return result;
        }
    }
}
 