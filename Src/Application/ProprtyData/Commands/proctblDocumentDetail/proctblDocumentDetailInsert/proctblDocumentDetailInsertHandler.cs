



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblDocumentDetail.proctblDocumentDetailInsert.proctblDocumentDetailInsertCommand
{

    /// @author  Shimels Alem  proc_tblDocument_DetailInsert stored procedure.


    public class proctblDocumentDetailInsertHandler : IRequestHandler<proctblDocumentDetailInsertCommand, IList<tblDocumentDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDocumentDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDocumentDetail_id>> Handle( proctblDocumentDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblDocumentDetail_id> result = await _procedureAdabter
                .Execute<tblDocumentDetail_id>("[ProprtyData].proc_tblDocument_DetailInsert", request);
           

            return result;
        }
    }
}
 